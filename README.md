Ollama AI Chatbot - C# Console Application

This guide explains how to install Ollama, set up a local LLM (Large Language Model), and integrate it with a C# Console Application using HttpClient.

1. Prerequisites
	Before starting, ensure you have the following:
 	> Windows 10/11 (or Linux/Mac)
 	> .NET SDK (6.0 or later) → Download Here
 	> At least 16GB RAM (for better performance)

2. Install Ollama
    >  Step 1: Download the Installer
    >  Go to the official Ollama website: https://ollama.com
    >  Download OllamaSetup.exe

    >  Step 2: Install Ollama
    >  Run OllamaSetup.exe → It will install in C:\Program Files\Ollama by default.
    >  If you want to install it in another location (e.g., D:\Ollama), you need to        	manually move the installation after setup.
    >  Step 3: Verify Installation
       Open Command Prompt (cmd) and run:
		ollama --version
       If installation is successful, it will display the installed version.

3. Download and Use a Model
   >   Step 1: Pull a Model
	To download the DeepSeek-R1 1.5B model, run:
	ollama pull deepseek-r1:1.5b
	This may take some time, depending on your internet speed.
   
   >   Step 2: Verify Model Installation
	Run the following command:
	ollama list
	It should display deepseek-r1:1.5b in the list.
5. Running Ollama Locally
	> Once the model is installed, you can test it by running:
	ollama run deepseek-r1:1.5b
	It will start an interactive chat session.

6. Using Ollama in a C# Console App
Step 1: Create a New Console Application
1) Open Command Prompt and navigate to your desired directory:
	cd D:\Projects
2) Create a new C# console project
	dotnet new console -n OllamaChatbot
3) Open the project folder:
	cd OllamaChatbot
Step 2: Install Required Packages
Run the following command to install System.Net.Http.Json (if needed):
	dotnet add package System.Net.Http.Json

Step 3: Add Your Code in Program.cs
	The chatbot code should already be present in Program.cs in this repository.
	It uses HttpClient to send user input to Ollama's local API and receives a 	response.

Step 4: Run the C# Chatbot
	In Command Prompt, navigate to your project folder and run:
	dotnet run
	Now, you can chat with the DeepSeek model running on your local machine! 🎉
6. Conclusion
	You have successfully:
		✅ Installed Ollama
		✅ Downloaded DeepSeek-R1 1.5B model
		✅ Created a C# Console Application to communicate with the model

		Now you can customize your chatbot by adding streaming, improving UI, or 		using it in a WinForms/WPF/ASP.NET Core applications. 🚀

		Let me know if you need any modifications! 😊

Why I Chose Ollama?
Initially, I tried using Microsoft Semantic Kernel with OpenAI and Azure OpenAI API keys. 
However, these services require a paid subscription. 
To avoid costs and ensure local execution, I opted for Ollama, which allows running AI models entirely offline.

