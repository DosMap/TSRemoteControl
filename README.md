# TSRemoteControl
Terminal Server Remote Control for Windows 2012

This project was created to implement a simple application that enables a user to control certain functionalities from a Terminal Server.

The functionalities of this application are:
- Maintain a list of terminal server machines
- For each machine on the list:
	- List the connected users
- For each connected user 
	- Remote control the session of the user
	- Send a message to the user
	- Logoff the user


This project uses the **Cassia .NET library**.
Cassia is a .NET Windows Terminal Services library that uses the MIT License and can be found at https://code.google.com/p/cassia/ or at https://github.com/gunmetal313/cassia

This project uses the **DataGridView Filter Popup library**.
DataGridView Filter Popup is a .NET library developed by Vincenzo Rossi that extents DataGridView capabilities to add row filtering. The library can be found at https://www.codeproject.com/Articles/33786/DataGridView-Filter-Popup
