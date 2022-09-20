while True:
    name = input("Welcome to my game. \nPlease enter your name: ")
    print(f"Welcome {name}")
    while True:
        name = name.capitalize()
        name_uppercase = name.upper()
        if name_uppercase.find("TURNER") != -1:
            break
        
        option_one = input(f"{name}, you were a drug dealer and are now looking for a better life. Due to a lack of experience you opt to put 'involved in production and distribution of leisure material' on your resume. While interviewing for the job, the interviewer asks what you meant by that. What do you do? \n1. BE HONEST (and explain what it means) \n2. LIE (through the skin of your teeth) \n3. PISS (on their desk)\n")
        if option_one == "1":
            option_two = input("You tell the truth. 'I sold drugs' you say. He shakes your hand and hires you on the spot. He immedietly rips open your jaw and snorts cocaine directly out of your mouth. \n1. KISS HIM (on the mouth) \n2. KILL HIM (with the M16 sitting on his desk)\n")
            if option_two == "1":
                print("You kiss him on the mouth and you like it. He does not.")
                break
            elif option_two == "2":
                print("You whip out the M16 laying on his desk and pump him full of lead and then you shoot him. You find his ID in his pocket and realize he was running for president. Now what do you do? \n1. Become president \n2. Turn him into a puppet and run as a puppet \n3. Tell his wife\n")
                break
            else:
                print(f"{option_two} is not a valid option.\n")
            break
        elif option_one == "2":
            print("You lie.")
            break
        elif option_one == "3":
            print("You piss on his desk. 'Shall we take this somewhere more private?' he asks. You agree as he takes you to the bathroom and kills you instantly.")
            break
        else:
            print(f"{option_one} is not a valid option.\n")
    
    play_again = input(f"YOU DIED.\nPlay again (y/n): ")
    if play_again.upper() == "N":
        break
print("Thank you so much for to playing my game.")