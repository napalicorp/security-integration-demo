# Overview
This is a sample project that demonstrate how to integrate security tools with the developer workflow. The demo uses a simple Azure Functions (.NET) sample as the codebase. It uses a GitHub Actions workflow to integrate with a hosted instance of [SonarQube](https://github.com/amalabey/sonarqube-supercharged). This hosted version of SonarQube (Community Edition) contains a number of plugins to make it a fully featured code scanning platform as illustrated below.  
  

![CI/CD Architecture](docs/Architecture.jpg)

**Note:** *This solution contains code that it deliberately vulnerable for demonstration purposes. Highly recommend not to expose the running application to the public. If exposed, the hosting infrastructure will be vulnerable to attacks*  


# Demo
This sample demonstrates how to prevent following security issues using the above toolset:  

| Branch         | Pull Request                                                                                               | Vulnerability         |
|----------------|------------------------------------------------------------------------------------------------------------|-----------------------|
| sql-injection  | [Ad sqlite based caching](https://github.com/amalabey/security-integration-demo/pull/1)                    | SQL Injection         |
| cmd-injection  | [Send crash logs to syslog using logger](https://github.com/amalabey/security-integration-demo/pull/2)     | Command Injection     |
| vuln-dep       | [Bulk load cache data using Zip file](https://github.com/amalabey/security-integration-demo/pull/3)        | Vulnerable Dependency |
| secret-checkin | [Add FinHub API integration](https://github.com/amalabey/security-integration-demo/pull/4)                 | Committed Secret      |
| vuln-iac       | [Add Bicep template for solution deployment](https://github.com/amalabey/security-integration-demo/pull/5) | Vulnerable IaC Code   |
  
# How to use the Pipeline?
You can use the GitHub actions pipeline in this sample to integrate your code repository with SonarQube. You need to set the following secrets in the  GitHub repository to make it work. You need to host and run an instance of the [SonarQube Supercharged](https://github.com/amalabey/sonarqube-supercharged) docker container in your cloud provider before proceeding. Then folow the instructions in the SonarQube instance under "Administration -> DevOps Platform Integrations" to integrate the hosted instance with your code repository. Once the integration is completed, you can copy the GitHub Actions workflow provided with this repository to yours and set below secrets in your GitHub repository.

- SONAR_HOST_URL
- SONAR_PROJECT_KEY
- SONAR_TOKEN