# DevOps, Continuous Integration, Continuous Delivery, and Continuous Deployment

# DevOps - - Jamaal Fisher

### DevOp-LifeCycle:

<img src="https://pimages.toolbox.com/wp-content/uploads/2021/08/26123909/DevOps-Lifecycle.png" width="600">

## Definition of DevOps

DevOps is a collaborative culture with a set of practices, ideas, tools, technologies, and processes that streamline the product development process.
This huge cultural shift lays emphasis on effective communication, integration, and better collaboration among teams for delivering quality products.
Basically, DevOps is a methodology that helps organizations build software - and their production teams - in a way that enables continuous rapid deployment.
In the words of Patrick Debois, the Godfather of DevOps, “it is a movement of people who think it’s time for a change in the IT Industry - time to stop wasting money, time to start delivering great software, and building systems that scale and last”.

## Key Disadvantages of DevOps

- Organizational: Focusing more on delivering working software than on documentation is preferred by both DevOps and its foundational Agile roots, but it may become more difficult for developers and operators to keep track of their advances as well.
- Processes: It will take time for users to adjust to a change in velocity.  Procedurally, the organization will need to be more fault-tolerant at least in the early going. Mistakes must be made and observed to stimulate rapid learning and resolution. This will be uncomfortable to some.
- Technology: While automation can be a good thing to ensure that the pace of operations can keep up with the DevOps continuous feedback cycle, it can have unintended consequences if the automation is not set up properly and monitored.
- Speed and Security: Speed and security don’t necessarily get along with each other very well. Rapid development can lead to severe security shortfalls if there is not a separate plan of action to ensure that speed is not outpacing the security systems designed to protect the products.

### Key Groups:

<img src="https://cdn.mos.cms.futurecdn.net/8jcis7FAV29qaanUV7E7Wj-970-80.jpg.webp" width="600">

## Key Groups of DevOps Culture:

- Development
  - Development gives Operations continuous feedback, while Operations gives Development automated provisioning.

- Operations
  - Operations gives QA continuous feedback, while QA gives Operations automated testing.

- Quality Assurance (QA)
  - QA gives Development continuous feedback, while Development gives QA automated build and deploy.

### Key Phases

<img src="https://i.imgur.com/u6RqFJp.png" width="600">

## Key Phases of DevOps Culture:

- Planning phase: development decides on plans, keeping in mind the application objectives to deliver to the customer
- Coding phase: teams works on the same code, then stores the original code and different versions of the code in a repository, and merge when required in a process called version control.
- Build phase: the code is made executable.
- Test phase: the code is tested for any bugs or errors through automation.
- Deploy phase: ready for deployment, sent to operations.
- Operate phase: deploys for the working environment.
- Monitor phase: the product is continuously monitored.  the feedback received is sent back to the planning phase.
- Integration phase: the core of the DevOps life cycle.  if the code adjustments pass the test, it is sent back through the phases in a process called continuous integration (CI).

# Continuous Integration - Blake Anderson

## Continuous Integration

Highly misunderstood. People often think they are doing it when they are not.
Essentially it is the process of continuously merging and testing small, incremental changes to the code base that all developers on a team are working on. 

<img src="https://wpblog.semaphoreci.com/wp-content/uploads/2020/02/preview-lightbox-Group-4439.jpg" width="600">

## Before Continuous Integration

 People worked individually for extended periods of time until a whole feature was done and their code diverged and caused merge conflicts.
 This was problematic
 Some call it “merge hell”

## How to Fix Merge Hell?

In short, continuous integration.
 As soon as some small aspect of the code works, it is merged.
 Everyone is working on the same code base in principle.
 Everyone is merging so often that the code doesn’t diverge.

## Stages of CI:

- Develop
- Build
- Test
- Stage

## Testing

Continuous integration can lead to things being continuously broken
 That’s where testing comes in.
Testing is the safety net.
 Code only merges if tests pass, so you always have a testable build.

<img src="https://code-maze.com/wp-content/uploads/2016/02/ci-cycle-2.png" width="600">

### Staging:

- An “idle” or staging environment allows for validation before moving to the production or “live” environment.
- Changes proceed to the idle environment and staged until the code is ready to deploy.
At this point the idle environment becomes the new production environment and vice versa.

## In Summary

 CI is the process of automating the building and testing of an application after each incremental and functional change to the code base.
 These changes only impact the code base if they are functional (meaning they pass the automated tests set in place).
# Continuous Delivery-  Daniel Oszczapinski

## What is Continuous Delivery?

- Continuous Delivery occurs and the end of the Continuous Integration cycle and can be or is usually combined into one together.
- Continuous Delivery takes Continuous Integration one step further, after a build and automated unit tests are successful, then it can be deployed in an environment where there is more in-depth testing and move to any other additional stages/environments.
- This also includes continuous feedback from users to implement necessary fixes to ensure the code is always in a deployable state.
- Continuous Delivery has a focus on the release and release strategy
- There also need to be a release manager that checks the code before the deployment stage.
- *Important* - Continuous delivery is a partly manual process for deployment. This gives the options on when to deploy the product.

<img src="https://www.researchgate.net/profile/Awais-Jumani/publication/339135798/figure/fig2/AS:856678622830592@1581259508160/Continuous-delivery-and-deployment.png" width="600">

## Why use Continuous Delivery

- Time-to-Value Proportion - which means the team spends less time on debugging and more time on valuable functionality. This means shorter times between user interaction and updates.

- Maximum automation - this means that testing and deployment stages are automated.

- High quality and low risk - The number of bugs or mistakes are reduced significantly because there is every stage goes through Continuous automated verification of deployment.

- Reduced cost - Reduce the cost by revealing bugs as early as possible.

## Pros and Cons of Ci/CD

Pros:
- Speed of deployment
- Faster testing and analysis
- Smaller code changes
- Better and faster fault isolation
- Increased code coverage
- Automatic deploy to production
- Never ship broken code
- Process is repeatable
- Faster mean time to resolution
- Smaller backlog
- Improved customer satisfaction

Cons:
- New skill sets must be learned
- Steep learning curve to implement automation
- Big upfront investment
- Legacy systems rarely support CI/CD
- High degree of discipline and dedication to quality

## Tools that use CI/CD, Major cloud providers:

- GitHub - Version Control tool
- Gitlab - is a suite of tools for managing different aspects of 
- Docker - Container Management tools, that developers use to build, test and collaborate.

CI / Deployment Automation tools:
- Jenkins - One of the best known open source tools for CI/CD
- TeamCity - JetBrains’s build management and continuous integration server
- Bamboo - is a continuous integration server that automates the management of software application releases, thus creating a continuous delivery pipeline
the software development lifecycle.

# Continuous Deployment - James Alouch

## What is Continuous Deployment?

-  Continuous deployment (CD, or CDE) is a strategy or methodology for software releases where any new code update or change that makes it through the rigorous automated test process is deployed directly into the live production environment where it will be visible to customers.
-  Continuous deployment is a strategy in software development where code changes to an application are released automatically into the production environment. This automation is driven by a series of predefined tests. Once new updates pass those tests, the system pushes the updates directly to the software's users.

## What is the goal of a continuous deployment process ?

- 1.To minimize the cycle time that is required to write a piece of code. 
- 2.Test it to ensure that it functions correctly and does not break the application,
- 3.Deploy it to the live environment and collect feedback on it from users.
**Important:**
- 	Automation is a key driver of productivity for teams that are doing continuous deployment. -A robust battery of automated tests must be programmed to verify that new code commits are functional before they are automated, and additional tools are required to abort the deployment process and trigger human intervention when the tests reveal lower-than-expected quality results or outcomes.
-	Continuous deployment adds an element of risk to the software release process- as developers are frequently committing unproven code which could potentially contain bugs to the live environment. Organizations that implement continuous deployment must therefore develop real-time monitoring capabilities of the live environment to rapidly discover and address any technical issues that occur after a new release.

## Continuous Integration vs Continuous Deployment

- 	Continuous integration refers to the software engineering practice of merging all of the output from software development teams into a shared mainline several times daily.
-  The practice originated in the early 1990's with an over-arching purpose of preventing integration problems in the software development process that would result when development
## Why Should developers teams practice continuous integration?

- 1.	To avoid integration issues - by ensuring that their working copies are merged into the main code bank several times each day. These regular commits reduce the number of conflicting changes, and any discovered conflicts are small and can usually be fixed relatively quickly. 
- 2. In contrast, developer teams that only commit changes once per week or once per month can build up a lot of conflicts between builds, leading to more difficulties when integrating the code.
- Continuous deployment takes CI a step further and automates the code release process so that each time new commits are merged into the mainline, automated testing is conducted and a pass results in the update being pushed to the production environment. 
- The key to achieving continuous deployment is to start with a functioning work flow for continuous integration, then streamline and automate the application release process so you can roll out new releases on a regular basis.
**What is the difference between Continuous Deployment vs DevOps?**
- DevOps is a set of software development practices with an emphasis in shortening software development cycle times and time-to-value while frequently delivering updates and new features. 
- Continuous deployment strives to deliver frequent updates as well, but it does so through a specific approach to change integration and delivery that minimizes lead times and relies on automation to facilitate frequent testing and software releases.
- continuous deployment describes a single practice for software development,while  DevOps offers an entire range of processes and best practices that are designed to help dev teams deliver code quickly that is tightly aligned with business strategy and objectives.
- The DevOps framework includes third-party software recommendations for every stage of the product development process and guidelines for establishing a strong DevOps culture within your organization. These characteristics of DevOps are well beyond the scope of Continuous Deployment.
**What are the Benefits of Continuous Deployment?**
- 1.Maintain Capability for Quick New Releases
The most important feature of continuous deployment is that is enables developer teams to get their new releases into the production environment as quickly as possible. Most software companies can no longer rely on development methodologies that were common when developers released software updates once per year. Some companies are rolling out up to 10 deployments per day with continuous deployment.
- 2.Enable a More Rapid Feedback Loop with Customers
More frequent updates to your application means a shorter feedback loop with the customer. Using state-of-the-art monitoring tools, developer teams can assess the impact of a new change on user behavior or engagement and make adjustments accordingly. The ability to rapidly release changes is an asset when customer behavior indicates the need for a quick pivot or change in strategy.
- 3.Reducing Manual Processes with Automation
Continuous deployment is defined by its use of automation in the application deployment process. In fact, continuous deployment wants developers to automate the entire software development process to the greatest extent possible, especially when it comes to release testing. Automation doesn't just help developers push out new releases faster, they actually spend less time on manual processes and get more work done.

**Continuous deployment vs. continuous delivery**

- Continuous delivery is a software development practice where software is built in such a way that it can be released into production at any given time. 
## How do you accomplish this?

- 1 By making sure  continuous delivery model involves production-like test environments. 
- 2.By making sure New builds performed in a continuous delivery solution are automatically deployed into an automatic quality-assurance testing environment that tests for any number of errors and inconsistencies. 
- 3. After the code passes all tests, continuous delivery requires human intervention to approve deployments into production. 
- 4.The deployment itself is then performed by automation.
.
- Continuous deployment is the natural outcome of continuous delivery done well.
- Continuous deployment tools
- To continuously develop and deploy high-quality software improvements, developers must use the appropriate tools for building effective DevOps practices. Doing so not only ensures efficient communication between both developmental and operational departments but also minimizes or eliminates errors in the software delivery pipeline.
 **Some of the most crucial tools used in a continuous deployment workflow:**
**Version control:** Version control helps with continuous integration by tracking revisions to a particular project’s assets. Also known as “revision" or “source” control, version control helps to improve visibility of a project's updates and changes while helping teams collaborate regardless of where and when they work.
**Code review** As simple as it sounds, “code review” is a process of using tools to test the current source code. Code reviews help improve the integrity of software by finding bugs and errors in coding and help developers address these issues before deploying updates.
**Continuous integration (CI):** CI is a critical component of continuous deployment and plays a major part in minimizing development roadblocks when multiple developers work on the same project. A variety of proprietary and open source CI tools exist, each catering to the unique complexities of enterprise software deployments.
	**Configuration management:** Configuration management is the strategy and discipline of making sure all software and hardware maintain a consistent state. This includes proper configuration and automation of all servers, storage, networking, and software.
	**Release automation:** Application release automation (or application release orchestration) is very important when automating all of the activities necessary to drive continuous deployment. Orchestration tools connect processes to one another to ensure developers follow all necessary steps before pushing new changes to production. These tools work closely with configuration management processes to ensure that all project environments are properly provisioned and able to perform at their highest level.
	**Infrastructure monitoring:** When operating a continuous deployment model, it’s important to be able to visualize the data that lives in your testing environments. Infrastructure monitoring tools help you analyze application performance to see if changes you make have a positive or negative impact.
## What are Kubernetes?

- Kubernetes is a great open source solution to use when developing a continuous deployment pipeline.
## Why use Kubernetes? 

- 1.Because of its flexible, 
- 2.logical, and
- 3. intuitive user interface, 
- 4. Kubernetes makes it possible to reduce the common problems that arise when running into server usage restrictions and outages while supporting modern infrastructure and multicloud deployments.

## What are the importance of Kubernetes?

- 1.	Kubernetes helps increase the agility of DevOps processes. Because of its modular design, Kubernetes allows alteration of individual pods inside a service, as well as seamless transitions between pods. This flexibility helps development teams avoid server downtime and allows for maximum resource utilization when running microservices.
- 2.	 Kubernetes is also an extremely reliable platform that can detect the readiness and overall health of applications and services before they’re deployed to the public.
- Continuous deployment across diverse applications
- When creating continuous delivery or continuous deployment infrastructure, it’s important to source the right enterprise solution that will give your business the confidence it needs to automate software testing and deployment processes. IBM UrbanCode Deploy is an application deployment automation platform that provides the visibility, traceability, and auditing capabilities businesses need to drive their software development needs in one optimized package.
**Multicloud deployments**
- Using UrbanCode Deploy’s Easy Process and Blueprint Designer, organizations can create custom cloud environment models to visualize how their applications should be deployed to public, private, and hybrid cloud. 
- Blueprint Designer allows users to create, update, and break down full-stack computing environments while enabling full cloud orchestration capabilities. All environments can then be provisioned to deploy application components automatically or on demand.
**Distributed automation**

**UrbanCode Deploy** is a highly scalable solution that supports the dynamic deployment of all mission-critical applications and services. Architected to meet the unique requirements of enterprises deploying across multiple data centers, UrbanCode Deploy supports master server clustering and uses lightweight deployments to provide immediate availability of services.
## Quality gates and approvals

- Being able to rely on the accuracy of automated testing environments is absolutely critical to successfully achieving continuous deployment. For some environments, however, it’s necessary to create certain conditions that flag manual approvals to ensure that the right information is pushed to production at the right time. UrbanCode Deploy features deployment approvals and gates to give administrators more control, visibility, and auditing capabilities over their continuous deployment processes.

**Tested integrations**

- While UrbanCode Deploy supports the use of your own scripts, out-of-the-box plugins make deployment processes easier to design and manage. By using tested integrations, developers can utilize pre-built automation that has already been proven. This replaces the need to create custom scripts specifically for UrbanCode Deploy.
- IBM UrbanCode Deploy features advanced process orchestration and collaboration tools that make it possible for enterprises to organize all of their deployment needs in one easy-to-use, customizable dashboard. Whether deploying applications on-premise, off-premise, or across thousands of managed servers, UrbanCode Deploy gives you all the solutions you need to ensure continuous delivery and rapid deployment across your entire enterprise.
.
**Continuous deployment and IBM Cloud**

The ability to release code changes automatically into the production environment can help dramatically speed time to market. You can do this with IBM tools as well as integrations with third parties and open source plugins. IBM processes and tools can help you with one of the most challenging DevOps initiatives organizations face—building and modernizing applications on the journey to cloud.
# YAML - Yet Another Markup Langauge/YAML Ain't Markup Language - Jermaine Williams

## What is YAML?

- YAML is serialized markup langauge, similar to XML or JSON.
- It's often commonly used to format or serialize configuation files, just like XML or JSON
- It uses a Python-like style for it's format and syntax.

![](https://cdn.ttgtmedia.com/rms/onlineImages/itops-yaml_code_7_mobile.png)

- Example of how object data that is serialzed in YAML format looks like.

## Why Do We Use YAML?

- As stated before, it can be used another way to serialze object data from one IDE to a database in place of XML or JSON since it's much more easier to read and learn.
- However it's used more in a pipeline for application deployment through DevOps.

![](https://www.dotnetcurry.com/images/devops/yaml-cicd/image-4.png?w=321&h=218)

- Basic syntax/schema for using YAML in a Build Pipeline

## Pipleine Keywords

- Triggers are used to determine when to activate the pipeline.
  - There can be diffent kinds of ways to trigger your pipeline into activating. You can trigger it to run every time there a pull request to your repo, every time Continuous Intergration is involved whenever an update it pushed to certain branches, you can schedule it to run at midnight every day, or you can even activate it manually by typing <ins>none</ins> after the trigger keyword.

- Stages are use to organise jobs in a pipeline. Each stage can have one or more jobs. You can have stages depend on one another and run if they have ran or have each stage have a condition to run if the previous stages have their run's sucucceded.

- Jobs are a collection of one or more steps, every pipeline has at least one job. It's also the smallest unit of work that can be scheduled to run. Like stages, they can depend on things to run and can have contitions.
  - There are three types of jobs:
    - Agent Pool Jobs: ran on an agent, or an agent pool
    - Server Jobs: ran on Azure DevOps server
    - Container Jobs: ran in a container or an agent

    Each job inside an Azure Pipeline is ran on an agent.

- Agents are softwares that can run one job at a time
  - There are two kinds of Agents:
    - Self-Hosted: owned and managed by you or the client. It gives you more control to install dependant packages or build and deployments.
    - Microsoft Hosted: Microsoft provides a new VM (Virtual Machine) every time a job needs to run. Maintenance and upgrades on the VM would be managed by Microsoft.

- Tasks are the actual execution unit within a pipeline. A job can have more than one task. You define that work you want to do in your pipeline. Azure DevOps comes prebuilt with a plethora of options for what you would like to do for your task in your pipeline.

- Approvals are a feature along with Gates to control the workflow of the app's deployment pipeline. Each stage within the pipline's release can be configured with either a pre-deployment or post-deployment conditions that depend on the scenario that you might run into.
  - For example, you'd might want to use the Pre-Deployment feaure if a user has to manually validate a change request and approve the deployment to a certain stage.
  - Or you might want to use the Post-Deployment feature if a team wants to ensure there are no incidents that were reported after their app's deployment, before triggering a release for it.
- By using approvals, along with gates, and manual intervention you can take full control of your releases to meet a wide range of deployment requirements.

### References:

[Microsoft-CI/CD](https://docs.microsoft.com/en-us/aspnet/aspnet/overview/developing-apps-with-windows-azure/building-real-world-cloud-apps-with-windows-azure/continuous-integration-and-continuous-delivery)

[Youtube-Devop](https://www.youtube.com/watch?v=Xrgk023l4lI)

[Youtube-CI](https://www.youtube.com/watch?v=_zCyLT33moA)

[Youtube-Ci-Second](https://www.youtube.com/watch?v=1er2cjUq1UI&t=73s)

[Youtube-CD](https://www.youtube.com/watch?v=2TTU5BB-k9U)

[IBM-CompleteGuideDevops](https://www.ibm.com/cloud/learn/devops-a-complete-guide)

[Agile-Devops](https://theagileadmin.com/what-is-devops/)

[CI-Framework](https://www.scaledagileframework.com/continuous-integration/#:~:text=Continuous%20Integration%20%28CI%29%20is%20the%20process%20of%20taking,where%20they%20are%20ready%20for%20deployment%20and%20release)

[RedHat-CI/CD](https://www.redhat.com/en/topics/devops/what-is-ci-cd)

[Itporportal-DevopsvsCI/CD](https://www.itproportal.com/features/stop-messing-up-with-cicd-vs-devops-and-learn-the-difference-finally/)

[Altexsoft-CI/CD](https://www.altexsoft.com/blog/business/continuous-delivery-and-integration-rapid-updates-by-automating-quality-assurance/)

[PillarGlobal-AdvantagesofDevOps](https://www.3pillarglobal.com/insights/disadvantages-of-using-devops/)

[CD-Deployment](https://www.sumologic.com/glossary/continuous-deployment/)

[Sumlogic](https://www.sumologic.com/glossary/continuous-deployment/)

[Continous-Deployment-IBM](https://www.ibm.com/cloud/learn/continuous-deployment)
