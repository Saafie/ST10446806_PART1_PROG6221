# ST10446806_PART1_PROG6221
ON START: 

It displays a Logo saying Blubot Secure, with an automated voice over welcoming the user to the bot. 
 
Sound Track 
for the sound to work you must recreate the path, by adding the new path from your computer of the audio. 
string filePath = @"C:\Users\Insaaf Behardien\Documents\ST10446806_Prog6221_Part1\ST10446806_Prog6221_Part1\ProgAudio.wav; 

Replace it with the path on your computer to make it work. 

 

Questions  

It will ask your name. 

•Enter Name (needs to be more than 2 characters). 

How are you? / What can I ask you 

How are you? 
- Must contain the any/all of the word I, am, good, bad 

 

2.2. Will be asked how are you. 

-Any Phrase/ sentence with good/ bad, the bot will answer and after will lead to a list of next questions you can ask. 
 

 

What can I ask you 
-Can have any phrase or sentence, but it must contain ask (will be lead to a list of questions you can ask). 

 

3. it will then lead to questions such as what's your purpose?, pause with safety, what is phishing?, safe browsing. 

- These questions will lead to sub questions mentioned below: 

3.1. Purpose  

- this will give you the definition and will give you the option to go back to the previous question by clicking return. 

3.2 Password safety 

- it will give you the definition of password 
- it gives you three different questions: 
   types of password practices (gives three different types of practices) 
   what makes a strong password (gives three ways to make a strong password) 
   reusing passwords (explains why passwords shouldn't be reused) 
   and the last option to return the previous questions or type exit to quit. 
 
 3.3. Phishing 
- will give you the definition 
- it will give you 2 examples that is e-mail and smishing. 
- and last option type Return/quit (return to previous question or type exit to quit). 
 

3.4. safe browsing 
- gives you the definition 
 it'll lead to 2 questions. 

-How to practice safe browsing if typed: 

it will give three ways to practice safe browsing.  

- Typed what a VPN is: 

 it will give definition of VPN. 

- you can type return or exit 
 
 Error handling 
 If name is less than two liters the chatbot will display an area in red saying: 
 username must be more than two letters please try again. 
 
 if answer is empty or null it will display an error: 
 please enter a valid question in the red. E.g. please enter a valid question 
 
 if answer does not contain a specific word or a correct phrase containing the specific word it will tell you the user to enter a valid answer. E.g. please enter a valid answer 
