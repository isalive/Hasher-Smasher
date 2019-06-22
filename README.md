# Hasher-Smasher

IMPORTANT NOTE : I have very little experience with C#, if you are a developer please check my code and suggest changes that could potentially enhance security, or improve the code while also explaining why, so i can learn. 
If you are able to extract the password when the application is compiled into an .exe, tell me why and how can i improve my code. 

About this application : 
This application Encrypts and Decrypts user input strings using a locally stored password to both authorize and Encrypt/Decrypt

The default password is "mypassword" and it is under the variable "Encryption" in the SecretCode Class.
To change the password you must change the above mentioned variable to something you want and compile the programm again. 

Usage :
Either compile it yourself or download HasherSmasher.exe 

To Encrypt :
1 - Type the password in the top text box.
2 - Write anything you want ( for example "Hello" ) into the second text box that says "Insert String to Encrypt".
3 - Click "Check-Encrypt".
4 - The Encrypted string will appear in the last text box. You can copy its contents by clicking the C button next to the text box. 

To Decrypt : 
1 - Type the password in the top text box.
2 - Paste your previously encrypted string into the "Insert String to Decrypt".
3 - Click "Decrypt".
4 - The Decrypted string will appear in the second text box. This should be the text you entered before. 

Notes : 
- Supports various special charactes for the string you want to encrypt/decrypt. 
- If you change anything in the encrypted string and try to decrypt it, the programm will just crash.
- The button "Clear All" clears all text boxes. 
