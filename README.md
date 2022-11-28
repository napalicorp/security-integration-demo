# Overview
This is a sample project that demonstrate how to integrate security tools with the developer workflow. The demo uses a simple Azure Functions (.NET) sample as the codebase. It uses a GitHub Actions workflow to integrate with a hosted instance of [SonarQube](https://github.com/amalabey/sonarqube-supercharged). This hosted version of SonarQube (Community Edition) contains a number of plugins to make it a fully featured code scanning platform as illustrated below.  
  

![CI/CD Architecture](docs/Architecture.jpg)

**Note:** *This solution contains code that it deliberately vulnerable for demonstration purposes. Highly recommend not to expose the running application to the public. If exposed, the hosting infrastructure will be vulnerable to attacks*  
