ST10446806_PROG6221_PART2

ON START: 

It displays a Logo saying Blubot Secure, with an automated voice over welcoming the user to the bot. 
 
Sound Track 
for the sound to work you must recreate the path, by adding the new path from your computer of the audio. 
string filePath = @"C:\Users\Insaaf C:\Users\Insaaf Behardien\source\repos\testing assignment 1\testing assignment 1\testing assignment 1\ProgAudio.wav 

Replace it with the path on your computer to make it work. 

 

Questions  

It will ask your name. 

•Enter Name (needs to be more than 2 characters). 

How are you? / What can I ask you 

How are you?-Must contain the any/all the words (worried, scared, concerned, frustrated, angry, curious, interested, curious) 
 
Will be asked how are you. 
-Any Phrase/ sentence with the above mentioned, the bot will have an empathetic response depending on your mood  
mood = concerned 
E.g. It's completely normal to feel concerned. Let's go over some tips to protect yourself online. 
and will lead to a question asking your interest. 
 

What can I ask you 
-Leads to a Question asking your interest 
-Can have any phrase or sentence, but it must contain ask (will lead to a question asking your interest). 
 

Let me ask you first. Do you have a specific area of cybersecurity you're interested in, {userName}? (e.g., privacy, phishing, scam, passwords. 

UserName captures the name you entered in question 1 
The question will store your answer for Interest in a string called userInterest. 
 

3. it will then lead to questions such as what's your purpose?, Password safety, what is phishing?, safe browsing, Privacy Tips and Scam Tips. Any accidental misspelling e.g. "phish", "priv", "pass", "scam" will be caught in the bot and will replace it with the correct spelling and save it as the correct spelling. 

- These questions will lead to sub questions mentioned below: 

3.1. Purpose  

- this will give you the definition and will give you the option to go back to the previous question by clicking return. 

3.2 Password safety 

- it will give you the definition of password 
- it gives you three different questions: 
   types of password practices (gives three different types of practices) 
   -Practice tips are randomly generated each time you type in practice. 
   what makes a strong password (gives three ways to make a strong password) 
   reusing passwords (explains why passwords shouldn't be reused) 
   and the last option to return the previous questions or type exit to quit. 
 
 3.3. Phishing 
- will give you the definition 
- it will give you 2 examples that is e-mail and smishing. 
- and other options such as tips, more details and type Return/quit (return to previous question or type exit to quit). 
More details will give you a randomly picked more in-depth detail of phishing. 
Tips give randomly picked tips from a list and displays them every time you ask for a tip. 
-Yes, if you want tips no if you don't. 
 

3.4. safe browsing 
- gives you the definition 
 it'll lead to 2 questions. 

-How to practice safe browsing if typed: 

it will give three ways to practice safe browsing.  

- Typed what a VPN is: 

 it will give definition of VPN. 

- you can type return or exit 
 
3.5. Privacy Tips 
Randomly picks a tip from the list of privacy tips in the class privacy which bring out the information in the method privacy tips. 
 
3.6 Scam 
The same thing happens with scam the method listScams() is brought out from the class privacy and put into the ScamTips() method which is in the Program class. 
The tips are also randomly picked from the list to give a range of responses when the bot is asked for a tip. 
 
3.7 Exit 
It exits the console 
 
Recalling 
Name is recalled asking the user their interest and when the system exits the console will display the users name.  
userInterest is recalled in the topic that the user answered. 
E.g. Interest = privacy 
when the topic privacy is chosen then the bot will respond with: 
As someone who is interested in privacy... 
 
Dictionary picks up certain words such as: 
phishing, password, safe browsing, privacy and scam in a sentence. It leads to the corresponding question that contains the word. 
 
 Error handling 
 If name is less than two liters the chatbot will display an area in red saying: 
 username must be more than two letters please try again. 
 
 if answer is empty or null it will display an error: 
 please enter a valid question in the red. E.g. please enter a valid question 
 
 if answer does not contain a specific word or a correct phrase containing the specific word it will tell you the user to enter a valid answer. E.g. please enter a valid answer 
 
If the spelling is completely unrecognizable by interest the bot will say its an invalid answer. E.g. Sorry, I didn't recognize that interest. Please try one of: privacy, phishing, scam, or passwords. 

When asking for tips by phishing, if the answer isn't yes or no. It tells you to enter yes or no. 
 
PasswordPractices  
You can create a Strong password by 

Including special characters or numbers e.g. @,!,? (CyberAware, 2024). 

Using more Characters to create longer passwords (The Sun, 2024). 

Do not use personal information: Birthdays, Names, phone numbers (CyberAware, 2024). 

Biometric Passwords: It uses biological features to create passwords on your device, using biometric scanner that scans your unique features, to calculate the match percentage of your biometric password (CyberAware, 2024). 

Multi-Factor Authentication (MFA) is an authentication process that uses two ways to grant access to personal information and accounts. An OTP and a Password, an otp is a one-time code sent to the verified email or cell number (CyberAware, 2024). 

Strong passwords can be used to keep anyone from accessing your sensitive information, because stronger passwords are harder to crack (CyberAware, 2024). 

Protect your information, never share your personal information such as passwords and credit cards via email. Enable (2FA) two-factor authentication to protect your account, as well as use strong passwords that are unique for different accounts (CyberAware, 2024). 
 
Reusing passwords increases the risk of cyberattacks. If a hacker gets your password from one site, they could access other accounts too. Reused passwords are often sold on the dark web (The Sun, 2024). 

 
PhishingDetails  
 
Phishing is a cyber-attack, it is used by impersonating as an organization, services or individuals to deceive users and gain sensitive information (CSO Online, 2023). 
 
examples are 

Email - Links or downloads are sent via email, with the attacker disguised as a legitimate company (TechTarget, 2024). 

pressing on these links can cause you to be redirected to risky websites or have malicious malware installed on your device (Proofpoint, 2023). 

Smishing - SMS phishing where malicious links and websites are sent via text messages (Proofpoint, 2023). 

Attackers disguise themselves as trusted as trustworthy services such as banks and popular companies to steal your personal information using SMS, messages, emails and phone calls (CSO Online, 2023). 

Phishing is when attackers research the victim, this means they gather information on you to create realistic messages that's from a company or brand. They spoof emails and mimics professional communication (TechTarget, 2024). 

 With phishing attackers send links, attachments and expresses urgency in emails or messages. Links that lead you to a log in page that make you give out your log in information of you not carful. They link attachments to emails and messages that downloads malware onto your device and will send fake urgency messages to reset your password (Proofpoint, 2023). 

If you experience this is most likely to occur. When you click on a link and any form of phishing attacks, your personal information such as credentials will get stolen, malware will be installed, and financial fraud could occur (CSO Online, 2023). 
 
Privacy 
Avoid sharing personal information online, such as credit cards, posting birthdates or your location on social media. Disable location tracking and check privacy setting on all platforms (McAfee, 2020). 

When browsing sensitive content, use incognito mode, regularly clear your history and clear cookies to reduce tracking. Use Firefox or brave that focuses on privacy, they also have privacy extensions (McAfee, 2020).  

Revoke app access to files and information on your device. Reduce permissions to mics and install a VPN to hide your IP address (McAfee, 2020). 

Enable authentication methods to protect your account privacy and use strong passwords (CyberAware, 2024). 
 
Scams 
Shopping scams, use trusted online shopping website, and ensure the websites contain 'https://'.  Try to avoid sellers who uses crypto and gift cards to sell products to you (New York Post, 2023). 

Smishing, Avoid sending person personal information over SMS, when a person claims to be a trusted service such as a bank. banks do not ask for personal information over SMS (Mimecast, 2024). 

General Scam Protection, ensure to check bank statements regularly for any suspicious activity and report scams to banks and any relevant platforms and service (CyberAware, 2024). 
 
Safe Browsing  
3 Ways to Practice Safe Browsing: 

Install an Ad Blocker: Ad blockers prevent unwanted ads, some of which contain malicious redirects to unsafe websites (CyberAware, 2024). 

Use an Antivirus: An antivirus program protects you from malicious websites in real-time, detecting and blocking harmful files and browsers (CyberAware, 2024). 
 
Avoid Public Wi-Fi for Sensitive Transactions: Public Wi-Fi is usually not secure, making it easier for hackers to access your sensitive information. 
A VPN creates a secure and encrypted connection to the internet using a private network (CyberAware, 2024). 

Referencing 

CSO Online. (2024) What is phishing? Examples, types and techniques. Available at: https://www.csoonline.com/article/514515/what-is-phishing-examples-types-and-techniques.html (Accessed: 10 May 2025). 

CyberAware. (2023) Cyber security advice for individuals. Available at: https://www.cyberaware.gov.uk/ (Accessed: 1 May 2025). 

McAfee. (2020) 10 tips to keep your data private online. Available at: https://www.mcafee.com/blogs/privacy-identity-protection/10-tips-to-keep-your-data-private-online/ (Accessed: 1 May 2025). 

Mimecast. (2024) Smishing – SMS phishing definition, examples, and prevention. Available at: https://www.mimecast.com/blog/smishing-sms-phishing-definition-examples-and-ways-to-prevent-it/ (Accessed: 3 May 2025). 

Proofpoint. (2023) What is smishing? Available at: https://www.proofpoint.com/us/threat-reference/smishing (Accessed: 4 May 2025). 

TechTarget. (2024) What is phishing? Available at: https://www.techtarget.com/searchsecurity/definition/phishing (Accessed: 30 April 2025). 

The Sun. (2024) Cyber experts warn against reusing passwords. Available at: https://www.the-sun.com/tech/12146300/password-day-rule-common-mistakes-cybersecurity-tips-avoid/ (Accessed: 29 April 2025). 
