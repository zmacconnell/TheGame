while True:
    name = input("Welcome to my game. \nPlease enter your name: ")
    print(f"Welcome {name}")
    while True:
        name = name.capitalize()
        name_uppercase = name.upper()
        if name_uppercase.find("TURNER") != -1:
            break
        option_one = input("{name}, you were a drug dealer and are now looking for a better life. Due to a lack of experience you opt to put 'involved in production and distribution of leisure material' on your resume. While interviewing for the job, the interviewer asks what you meant by that. What do you do? \n1. BE HONEST (and explain what it means) \n2. LIE (through the skin of your teeth) \n3. PISS (on their desk)")
        if option_one == "1":
            print("You tell the truth")
        elif option_one == "2":
            print("You lie.")
        elif option_one == "3":
            print("You piss on his desk. 'Shall we take this somewhere more private?' he asks. You agree as he takes you to the bathroom and kills you instantly.")
            break
    play_again = input(f"YOU DIED.\nPlay again (y/n): ")
    if play_again.upper() == "N":
        break
print("Thank you so much for to playing my game.")