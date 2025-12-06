using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_System.Data_repo
{
    public class ATM_DatabaseRepo
    {
        private static readonly string ConnectionString = "Data Source=PhoenixTitan\\SQLEXPRESS;Initial Catalog=ATM_Database;Integrated Security=True";

        //Methods
        public UserData VerifyUserAccountInDB(string CardNumber, string pinCode)
        {
            string findUserQuery = "SELECT id, firstname, lastname FROM Users WHERE creditCardNumber = @cardNumber AND pinCode = @pin;";

            UserData userData = null;
            SqlDataReader reader = null;

            using (SqlConnection connection = new SqlConnection(ConnectionString))

            using (SqlCommand executeCommand = new SqlCommand(findUserQuery, connection))
            {
                // Add parameters for safe execution (CRITICAL STEP)
                executeCommand.Parameters.AddWithValue("@cardNumber", CardNumber);
                executeCommand.Parameters.AddWithValue("@pin", pinCode);

                try
                {
                    connection.Open();
                    reader = executeCommand.ExecuteReader();

                    // reader.Read() will be true only if a matching user is found
                    if (reader.Read())
                    {
                        // User found, instantiate and populate the User object
                        userData = new UserData
                        {
                            id = reader.GetInt32(reader.GetOrdinal("id")),
                            firstname = reader.GetString(reader.GetOrdinal("firstname")),
                            lastname = reader.GetString(reader.GetOrdinal("lastname")),

                        };
                    }
                }
                catch (Exception ex) {
                   

                    //This is for showing the error message
                    throw new ApplicationException("Database error during user lookup.", ex);

                }
                finally
                {
                    reader?.Close(); // Close the reader if it was successfully initialized
                }
            }

            return userData;
        }


        public (decimal UsdBalance, decimal LrdBalance) GetCurrentBalances(int userId)
        {
            // Use an INNER JOIN to ensure we only get a balance if the user exists
            string getBalancesQuery =
                "SELECT AB.USD_AccountBalance, AB.LRD_AccountBalance " +
                "FROM AccountBalance AB " +
                "WHERE AB.fk_User = @userId;";

            decimal usdBalance = 0m;
            decimal lrdBalance = 0m;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlCommand executeCommand = new SqlCommand(getBalancesQuery, connection))
            {
                executeCommand.Parameters.AddWithValue("@userId", userId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = executeCommand.ExecuteReader();

                    if (reader.Read())
                    {
                        // Retrieve both balances from the reader
                        usdBalance = reader.GetDecimal(reader.GetOrdinal("USD_AccountBalance"));
                        lrdBalance = reader.GetDecimal(reader.GetOrdinal("LRD_AccountBalance"));
                    }
                    // else: If no record is found, balances remain 0m.
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Database error retrieving balances.", ex);
                }
            }

            // Return the results as a C# tuple
            return (usdBalance, lrdBalance);
        }



        // Method to update either the USD or LRD balance for a specific user.
        public int UpdateAccountBalance(int userId, decimal depositAmount, string currency)
        {
            // Initialize the query string and parameter name based on currency
            string updateQuery;
            string balanceColumn; // The column to update

            if (currency.Equals("USD", StringComparison.OrdinalIgnoreCase))
            {
                // Add the deposit amount to the existing USD_AccountBalance
                balanceColumn = "USD_AccountBalance";
            }
            else if (currency.Equals("LRD", StringComparison.OrdinalIgnoreCase))
            {
                // Add the deposit amount to the existing LRD_AccountBalance
                balanceColumn = "LRD_AccountBalance";
            }
            else
            {
                // Should not happen if input validation is done correctly
                throw new ArgumentException("Invalid currency specified for deposit.");
            }

            // Construct the SQL command. It updates the balance by adding the new amount.
            updateQuery = $"UPDATE AccountBalance SET {balanceColumn} = {balanceColumn} + @amount, updatedAT = GETDATE() WHERE fk_User = @userId;";

            // Execute the command
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlCommand executeCommand = new SqlCommand(updateQuery, connection))
            {
                // Add parameters
                executeCommand.Parameters.AddWithValue("@amount", depositAmount);
                executeCommand.Parameters.AddWithValue("@userId", userId);

                try
                {
                    connection.Open();
                    // ExecuteNonQuery returns the number of rows affected (should be 1)
                    return executeCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException($"Database error during {currency} deposit update.", ex);
                }
            }
        }



        // Method to update either the USD or LRD balance for a specific user during withdrawal.
        public int UpdateAccountForWithdrawal(int userId, decimal withdrawalAmount, string currency)
        {
            string updateQuery;
            string balanceColumn; // The column to update

            if (currency.Equals("USD", StringComparison.OrdinalIgnoreCase))
            {
                balanceColumn = "USD_AccountBalance";
            }
            else if (currency.Equals("LRD", StringComparison.OrdinalIgnoreCase))
            {
                balanceColumn = "LRD_AccountBalance";
            }
            else
            {
                throw new ArgumentException("Invalid currency specified for withdrawal.");
            }

            // CRITICAL: The WHERE clause checks for sufficient funds BEFORE subtracting.
            // If the balance is less than the withdrawal amount, no rows will be affected (0).
            updateQuery = $"UPDATE AccountBalance SET {balanceColumn} = {balanceColumn} - @amount, updatedAT = GETDATE() WHERE fk_User = @userId AND {balanceColumn} >= @amount;";

            // Execute the command
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlCommand executeCommand = new SqlCommand(updateQuery, connection))
            {
                // Add parameters
                executeCommand.Parameters.AddWithValue("@amount", withdrawalAmount);
                executeCommand.Parameters.AddWithValue("@userId", userId);

                try
                {
                    connection.Open();
                    // ExecuteNonQuery returns 1 for success (funds sufficient) or 0 for failure (insufficient funds)
                    return executeCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException($"Database error during {currency} withdrawal update.", ex);
                }
            }
        }

    }

}
