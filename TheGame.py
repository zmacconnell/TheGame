while True:
    name = input("Welcome to my game. \nPlease enter your name: ")
    print(f"Welcome {name}")
    while True:
        name = name.capitalize()
        name_uppercase = name.upper()
        while name_uppercase.find("TURNER") != -1:
            print("You're gay!")
        
        option_one = input(f"{name}, you were a drug dealer and are now looking for a better life. Due to a lack of experience you opt to put 'involved in production and distribution of leisure material' on your resume. While interviewing for the job, the interviewer asks what you meant by that. What do you do? \n1. BE HONEST (and explain what it means) \n2. LIE (through the skin of your teeth) \n3. PISS (on their desk)\n")
        if option_one == "1":
            option_two = input("You tell the truth. 'I sold drugs' you say. He shakes your hand and hires you on the spot. He immedietly rips open your jaw and snorts cocaine directly out of your mouth. \n1. KISS HIM (on the mouth) \n2. KILL HIM (with the M16 sitting on his desk)\n")
            if option_two == "1":
                print("You kiss him on the mouth and you like it. He does not.")
                break
            elif option_two == "2":
                option_three = input("You whip out the M16 laying on his desk and pump him full of lead and then you shoot him. You find his ID in his pocket and realize he was running for president. Now what do you do? \n1. BECOME (president) \n2. TRANSFORM HIM (into a puppet and run as a puppet) \n3. TELL (his wife)\n")
                if option_three == "1":
                    print("BECOME PRESIDENT")
                    break
                elif option_three == "2":
                    print("PUPPET")
                    break
                elif option_three == "3":
                    print(f"You approach his home and knock on the door—his wife answers. You get cold feet right before telling her the truth and inform her that her husband was assassinated by some mysterious man. She breaks down immediately. You go to comfort her and you hug her. She feels relieved. You visit her often to make sure that shes recovering well. You even attend the funeral of her husband. Eventually, as the grief passes, you both feel the sparks of something more as you both grow closer. You both fall madly in love and even get married. Her family accepts you as apart of their family now. You finally feel happy for the first time in a long time. You eventually retire from work and live a peaceful life with your wife. \nOne day, you decide to take a trip to the local spa for some relaxation. Your wife had some errands to run and insisted that you go with out her. As you relax in a hot tub, a man approaches you. He looks pretty familiar. “Do you remember me {name}? If not this should jog your memory.” He takes off his shirt revealing a hole 1 foot in diameter in his chest. Suddenly the memories come flooding back to you. Its the man you assassinated! “I thought you were dead” you exclaimed. “Me too” he replies. He pulls an M16 out from under his towel and points it at you. He says “Hasta lá vista, baby.” You cringe.")
                    break
                else:
                    print(f"{option_three} is not a valid option.\n")
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