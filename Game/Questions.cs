using System;


namespace QuestionGame;
internal class Questions
{
    public void Main()
    {
        while (true)
        {
            Console.WriteLine("Welcome to my game. \nPlease enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Welcome {name}");
            while (true)
            {
                string capsName = name.ToUpper();
                while (capsName.Contains("TURNER") == true)
                {
                    Console.WriteLine("You're gay!");
                }

                Console.WriteLine($"{name}, you were a drug dealer and are now looking for a better life. Due to a lack of experience you opt to put 'involved in production and distribution of leisure material' on your resume. While interviewing for the job, the interviewer asks what you meant by that. What do you do? \n1. BE HONEST (and explain what it means) \n2. LIE (through the skin of your teeth) \n3. PISS (on their desk)");
                string optionOne = Console.ReadLine();
                if (optionOne == "1")
                {
                    Console.WriteLine("You tell the truth. 'I sold drugs' you say. He shakes your hand and hires you on the spot. He immedietly rips open your jaw and snorts cocaine directly out of your mouth. \n1. KISS HIM (on the mouth) \n2. KILL HIM (with the M16 sitting on his desk)");
                    string optionTwo = Console.ReadLine();
                    if (optionTwo == "1")
                    {
                        Console.WriteLine("You kiss him on the mouth and you like it. He does not.");
                        break;
                    }
                    else if (optionTwo == "2")
                    {
                        Console.WriteLine("You whip out the M16 laying on his desk and pump him full of lead and then you shoot him. You find his ID in his pocket and realize he was running for president. Now what do you do? \n1. Become president \n2. Turn him into a puppet and run as a puppet \n3. Tell his wife");
                        string optionThree = Console.ReadLine();
                        if (optionThree == "1")
                        {
                            Console.WriteLine("You become president. Now it's time to pick your vice president. Your options are: \n1. Bernard Standards \n2. Obmana \n3. Donny Trumpet");
                            string optionFour = Console.ReadLine();
                            if (optionFour == "1")
                            {
                                Console.WriteLine("You pick Bernard Standards. He's pretty basic, but 2 weeks in he falls out of his metal chair and dies instantly. Not a good look for the president. A mob forms, blaming you for all student debt. What do you do? \n1. EXECUTE (everyone standing outside) \n2. BE CIVIL (and hear them out)");
                                string optionFive = Console.ReadLine();
                                if (optionFive == "1")
                                {
                                    Console.WriteLine("Execution is the only obvious answer. You determine the entire mob outside to be terrorists and enemies of hte state and sentence them all to execution. This does not go across well, but it is much qieter. THis gives you some time to work on your political agenda. What do you do first?");
                                }
                                else if (optionFive == "2")
                                {
                                    Console.WriteLine("You invite the mob inside so you can talk about th eissues presented. As soon as the doors open someone in the back of the crowd stoots off a bolt from a crossbow made of paper straws. This misses you, but passes cleanly through the neck of the stuffed corpse of Bernard that is still hanging in the hall during the mandatory mourning month. This immedietly quiets the crowd. In this circumstance the laws are clear. All those in the company must perform ritual seppuku, including yourself. The secret service members start passing out Kool-Aid. You look deeply into the cup and wonder how it came to this.");
                                }
                                else
                                {
                                    Console.WriteLine($"{optionFive} is not a valid option.");
                                }
                            }
                            else if (optionFour == "2")
                            {
                                Console.WriteLine("You pick Obamna. Now you can say the N-word. Go ahead. Say it. \n1. SAY (the N-word) \n2. DON'T SAY (the N-word)");
                                string optionFive = Console.ReadLine();
                                if (optionFive == "1")
                                {
                                    Console.WriteLine("Bad choice.");
                                    break;
                                }
                                else if (optionFive == "2")
                                {
                                    Console.WriteLine("You would if you weren't a f***ing coward.");
                                    break;
                                }
                            }
                            else if (optionFour == "3")
                            {
                                Console.WriteLine("You pick Donny Trumpet. He screams into your face and sucks your eyes out of your head like oysters out of their shells. You are now blind. What do you do? \n1. GIVE UP (and let Donny be president) \n2. SWING (with your fist)");
                                string optionFive = Console.ReadLine();
                                if (optionFive == "1")
                                {
                                    Console.WriteLine("You can't take this abuse anymore, you let Donny be president. He immedietly decides to deport all blind people to Mexico. This includes you. What are you going to do about it? \n1. BEG (for mercy) \n2. GO (to Mexico)");
                                    string optionSix = Console.ReadLine();
                                    if (optionSix == "1")
                                    {
                                        Console.WriteLine("You beg for mercy. “Good,” Donny says, “Gooooooood. From this time forth, you shall be known as ... Darth Vader.” \nYou wake up 2 weeks later. You hear machines on all sides, whirring and clicking. You open your eyes and a bright light fills them. Considering the last thing you remember is your eyes being sucked out, you are quite relieved. Then you remember more and realize what happened. “Where is Padme,” you ask, “Is she safe? Is she alive?” Donny looks at you with pitty. “lmao,” he says. You sob. \n1. OBEY (your new masters bidding) \n2. REBEL (against Donny's rule)");
                                        string optionSeven = Console.ReadLine();
                                        if (optionSeven == "1")
                                        {
                                            Console.WriteLine("You obey. He sends you to kill some jedi off in the unknown regions. Its a bald man being humped by a child. The hunt begins.");
                                            break;
                                        }
                                        else if (optionSeven == "2")
                                        {
                                            Console.WriteLine("“No,” you say. You can't take another day with him, not after being turned into a monster. Donny says, “Hasta lá vista, baby.” He throws you off a cliff using the force.");
                                            break;
                                        }
                                    }
                                    else if (optionSix == "2")
                                    {
                                        Console.WriteLine("Mexico is nice. You can't really see it, but it's warm, propably has an orange-ish tinge. You could see yourself live out the rest of your life here. Well, figuratively speaking.");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{optionSix} is not a valid option.");
                                    }
                                }
                                else if (optionFive == "2")
                                {
                                    Console.WriteLine("You idiot. You're blind! Well, Donny easily dodges your swing and says 'Then a fight it will be.' You hear him go Super Saiyan. Now what are you going to do? ");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"{optionFive} is not a valid option.");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"{optionFour} is not a valid answer.");
                            }
                        }
                        else if (optionThree == "2")
                        {
                            Console.WriteLine("You decide to use your previous potential employer as a puppet and win him the election! But how will you turn him into a puppet? \n1. SKIN HIM (and turn his skin into a suit) \n2. USE DOWELS (like a muppet) \n3. SUNGLASSES (and roll him around in a wheelchair)");
                            string optionFour = Console.ReadLine();
                            if (optionFour == "1")
                            {
                                Console.WriteLine("Gross, but you skin him and wear said skin around like a suit.");
                                break;
                            }
                            else if (optionFour == "2")
                            {
                                Console.WriteLine("Not a convention way to solve this problem, but you jam dowles into his arms and legs and use him as a puppet.");
                                break;
                            }
                            else if (optionFour == "3")
                            {
                                Console.WriteLine("You decide the best option here would be to fake him having been injured and roll him around with glasses on. He will start to stonk after a while, but hey, that's a you problem.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"{optionFour} is not a valid answer.");
                            }
                        }
                        else if (optionThree == "3")
                        {
                            Console.WriteLine($"You approach his home and knock on the door—his wife answers. You get cold feet right before telling her the truth and inform her that her husband was assassinated by some mysterious man. She breaks down immediately. You go to comfort her and you hug her. She feels relieved. You visit her often to make sure that shes recovering well. You even attend the funeral of her husband. Eventually, as the grief passes, you both feel the sparks of something more as you both grow closer. You both fall madly in love and even get married. Her family accepts you as apart of their family now. You finally feel happy for the first time in a long time. You eventually retire from work and live a peaceful life with your wife. \nOne day, you decide to take a trip to the local spa for some relaxation. Your wife had some errands to run and insisted that you go with out her. As you relax in a hot tub, a man approaches you. He looks pretty familiar. “Do you remember me {name}? If not this should jog your memory.” He takes off his shirt revealing a hole 1 foot in diameter in his chest. Suddenly the memories come flooding back to you. Its the man you assassinated! “I thought you were dead” you exclaimed. “Me too” he replies. He pulls an M16 out from under his towel and points it at you. He says “Hasta lá vista, baby.” You cringe.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"{optionThree} is not a valid answer.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{optionTwo} is not a valid option.");
                    }
                }
                else if (optionOne == "2")
                {
                    Console.WriteLine("You try to lie and he sees right through you. You pull out your enchanted crystal meth blade and swipe at him. The blade passes stright through him. What do you do? \n1. SCREAM (in his face) \n2. CRY (on the ground)");
                    string optionTwo = Console.ReadLine();
                    if (optionTwo == "1")
                    {
                        Console.WriteLine("You scream and he pees himself. 'LMAO' you say. His sobbing becomes uncontrolable. Fluids begin flowing from every part of the human body that can expel fluids, and some that can't. This isn't good. What do you do? ");
                        break;
                    }
                    else if (optionTwo == "2")
                    {
                        Console.WriteLine("The magical crystal meth sword falls to the ground next to you and you lay down and sob uncontrollably. You're a baby.");
                        break;
                    }
                }
                else if (optionOne == "3")
                {
                    Console.WriteLine("You piss on his desk. 'Shall we take this somewhere more private?' he asks. You agree as he takes you to the bathroom and kills you instantly.");
                    break;
                }
                else
                {
                    Console.WriteLine($"{optionOne} is not a valid answer. Please input 1, 2, or 3.");
                }
                break;
            }
            Console.WriteLine("YOU DIED\nPlay again (y/n)? ");
            string keepPlaying = Console.ReadLine();
            if (keepPlaying.ToUpper() == "N")
            {
                break;
            }
        }
    Console.WriteLine("Thank you for playing!");
    }
}