from pprint import pprint
import pyodbc

# Set up the connection details
server = 'testonly.database.windows.net'
database = 'companyDB'
username = 'akoonly'
password = 'Number@123!'

# Set up the connection string
connection_string = f'DRIVER={{ODBC Driver 17 for SQL Server}};SERVER={server};DATABASE={database};UID={username};PWD={password}'

# Establish a connection
with pyodbc.connect(connection_string) as conn:

    # Create a cursor object to execute SQL queries
    cursor = conn.cursor()

    # Execute your query
    user_input = input("Enter Proper SQL Query: ")
    query = user_input
    cursor.execute(query)

    # Retrieve the query results
    rows = cursor.fetchall()
    

    # Process and print the results
    for row in rows:
        pprint(row, width=1)
