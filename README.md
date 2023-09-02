# EmailPRO
This project is a simple email/chatter simulator app written in the __WCF framework__ and __WinForms__, using __C#__ language.  
I hope you are gonna like it! ;)

## Important notes
+ To test the project on your own after pulling the repo down onto your local machine:
  1. Open the __WcfTestSolution.sln__ file and run the solution in your IDE, since it acts as a remote service for the desktop app (it has to "come to life" first).
  2. Open the __TestApp.sln__ file and run it. I suggest running 2 instances, to better simulate live chat between 2 people. Simply register 2 new users and go ahead with simulating the chat! I believe the interface is intuitive enough for anyone to get the hang of all the functionalities in a minute or two.
+ Main features:
  - The command line (the one that opens when you run __WcfTestSolution.sln__) is gonna detect and update the output every time you register a new user, or to say what happens underneath: when a new user record appears in the database.
  - You can register new users in the login/register form that pops up first when you run __TestApp.sln__. 2 users with identical logins can't be registered.
  - You cannot log in if a user with a given login doesn't exist in the database. Otherwise, after entering the correct credentials you will enter the main form of the application.
  - In the main form, you can:
    * view your history of received and sent messages + you can filter them by searching for a substring,
    * view details of the chosen message (it's content, when it was sent, whether it was read or not, other user's status),
    * refresh the form to see all sent/received messages since the last refresh,
    * write new message,
    * delete messages that you sent.
