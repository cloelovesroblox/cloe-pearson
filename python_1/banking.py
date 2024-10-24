# Your initial data (variables)
username = "Watermelon"  # Username of the user
nickname = "kooiaid"  # Nickname of the user
age = 16  # Age of the user (integer)
bankAccountValue = 25.50  # Current balance in the user's bank account (float)
lottery_amount = 600000000  # Lottery prize amount (float)

# Introduction print statements
print("Your username is:", username)  # Prints the username
print("Your nickname is:", nickname)  # Prints the nickname
print("Your age is:", age)  # Prints the age
print("Your account value is:", bankAccountValue)  # Prints the bank account value

# Decision structure (if-else statement)
# Here we're checking if the user's bank account value is high enough
if bankAccountValue > 100:
    print("You have enough money in your account!")
else:
    print("Your account is low. You should consider saving more.")

# List of lottery tickets (list data type)
# We’re simulating that the user bought some lottery tickets with different numbers
lottery_tickets = [1234, 5678, 7777, 9012]  # This is a list of lottery ticket numbers

# Function to check if any of the lottery tickets is a winner
def check_lottery_winnings(tickets, prize):
    """
    Function that checks if any ticket is the winning number.
    If a ticket wins, the function prints a congratulatory message.
    
    Parameters:
    tickets (list): A list of ticket numbers
    prize (float): The lottery prize amount
    
    Returns:
    None
    """
    winning_number = 7777  # Predefined winning number
    
    # Loop through the list of tickets
    for ticket in tickets:
        if ticket == winning_number:
            print(f"Congratulations! Ticket {ticket} wins ${prize:.2f}!")  # You win if ticket matches
        else:
            print(f"Ticket {ticket} did not win. Try again next time!")  # If not, no win

# Calling the function to check for winnings
check_lottery_winnings(lottery_tickets, lottery_amount)

# Loop example
# Let's say you want to print your bank account value multiple times
for attempt_number in range(3):  # This loop will run 3 times
    print(f"Attempt {attempt_number + 1}: Your bank account value is ${bankAccountValue:.2f}")
