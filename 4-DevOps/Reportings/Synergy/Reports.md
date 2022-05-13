<h1><b>Contanerization & using Docker</b></h1>
<p>By: Leo Ware, Vladimir Shnyakin, Kevin Pilatzke, Randy Robinson and Osman Elmahadi</p>

<br>
<break></break>
<br>
<h3><b> Containerization definition</b></h3>

<p>Containerization is a form of virtualization where applications run in isolated user spaces, called containers, while using the same shared operating system (OS). With containerization, there’s less overhead during startup and no need to set up a separate guest OS for each application since they all share the same OS kernel. Each container is an executable package of software, running on top of a host OS. A host may support many containers (tens, hundreds, or even thousands) concurrently, such as in the case of a complex microservices architecture that uses numerous containerized application delivery controllers (ADCs). This setup works because all containers run minimal, resource-isolated processes that others cannot access.</p>
<br>


<h3><b> Virtualization:</b> </h2>

<p>Virtualization is a technique of how to separate a service from the underlying physical delivery of that service. It is the process of creating a virtual version of something like computer hardware. It was initially developed during the mainframe era. It involves using specialized software to create a virtual or software-created version of a computing resource rather than the actual version of the same resource. With the help of Virtualization, multiple operating systems and applications can run on same machine and its same hardware at the same time, increasing the utilization and flexibility of hardware. </p>
<br>

<h3><b> Hyper V / Hypervisor:</b> </h2>

<p> A Hypervisor or VMM(virtual machine monitor) is a layer that exists between the operating system and hardware. It provides the necessary services and features for the smooth running of multiple operating systems. <br>
It identifies traps, responds to privileged CPU instructions, and handles queuing, dispatching, and returning the hardware requests. A host operating system also runs on top of the hypervisor to administer and manage the virtual machines</p>
<br>

<h3><b>Difference between virtualization and Hypervisor</b></h3>

<b>Virtualization:</b>
<ul>
<li> It uses software to create virtual version of something rather than actual one.</li>

<li> It generally allows to use physical machines full capacity simply by distributing its capabilities among different users and environments.</li>

<li> Its main function is to manage workloads by transforming tradition computing radically simply to make it more scalable.</li>

<li> It is generally used for testing application on different platforms for OS, to conserve physical space, reduce cost, increase efficiency and productivity, etc…</li>

<li>Its advantages include control independence and DevOps, enhance resiliency, reduce downtime, simplify data center management, etc. </li>

<li> It is more cost-effective as compared to hypervisors. </li>
</ul>

<b>Hypervisor:</b>
<ul>
<li>It is software used to create and run virtual machines. </li>

<li> It generally allows one host computer to support various guest virtual machines simply by sharing its resources virtually. </li>

<li> Its main function is to allocate system resources properly to each virtual machine that it manages.</li>

<li> It is most effective way to ensure that virtual machines are working effectively or not, smooth functioning of virtual machine, reduces costs of operations, etc. 
It is generally used for various tasks such as cloud computing, server management, running programs compatible with OS, etc.</li>
  
<li> Its advantages include consolidating servers, desktop virtualization, data replication, etc.  </li>

<li> It is less cost-effective as compared to virtualization. </li>
</ul>

<em> Learn more:  https://www.geeksforgeeks.org/difference-between-virtualization-and-hypervisor/</em>


<br>
<h3><b> Advantages of containerization over regular deployment:</b></h3>

<ul>
    <li><b>Reduced cost of infrastructure operations:</b> There are usually many containers running on a single VM</li>
    <li><b>Solution scalability on the microservice/function level:</b> No need to scale instances/VMs</li>
    <li><b>Better security:</b> Full application isolation makes it possible to set each application’s major process in separate containers</li>
    <li><b>Instant replication</b> of microservices via replicas and deployment sets</li>
    <li><b>Flexible</b> routing between services that are natively supported by containerization platforms</li>
    <li><b>Deploy anywhere:</b> Including hybrid environments</li>
    <li><b>Full portability</b> between clouds and on-premises locations</li>
    <li><b>OS independent:</b> They don’t need an OS to run; only the container engine is deployed on a host OS</li>
    <li><b>Fast deployment</b> with hydration of new containers and termination of old containers with the same environments</li>
    <li><b>Lightweight:</b> Without an OS, containers are lightweight and less demanding on server resource usage than images</li>
    <li><b>Faster “ready to compute”:</b> Containers are ready to start and stop within seconds in comparison to VMs.</li>
</ul>
<br>

<h3><b> There are several popular containers:</b> </h3>
<ol>
    <li> Docker.</li>
    <li> AWS Fargate.</li>
    <li> Google Kubernetes Engine.</li>
    <li> Amazon ECS.</li>
    <li> LXC.</li>
    <li> Container Linux by CoreOS.</li>
    <li> Microsoft Azure.</li>
    <li> Google Cloud Platform</li>
</ol>

<br>
<br>

<h3><b> What is Docker???</b> </h3>

<p>Package Software into Standardized Units for Development, Shipment and Deployment<br>
A container is a standard unit of software that packages up code and all its dependencies so the application runs quickly and reliably from one computing environment to another. A Docker container image is a lightweight, standalone, executable package of software that includes everything needed to run an application: code, runtime, system tools, system libraries and settings.</p>

<p>Container images become containers at runtime and in the case of Docker containers – images become containers when they run on Docker Engine. Available for both Linux and Windows-based applications, containerized software will always run the same, regardless of the infrastructure. Containers isolate software from its environment and ensure that it works uniformly despite differences for instance between development and staging.</p>

<br>

<h3><b> Docker containers that run on Docker Engine:</b> </h3>

<p><b> Standard:</b> Docker created the industry standard for containers, so they could be portable anywhere.<br>
<b> Lightweight:</b> Containers share the machine’s OS system kernel and therefore do not require an OS per application, driving higher server efficiencies and reducing server and licensing costs.<br>
<b> Secure:</b> Applications are safer in containers and Docker provides the strongest default isolation capabilities in the industry</p>
			
<br>

<h3><b> Docker Engine Sparked the Containerization Movement</b> </h3>
<p> Docker Engine is the industry’s de facto container runtime that runs on various Linux (CentOS, Debian, Fedora, Oracle Linux, RHEL, and Ubuntu) and Windows Server operating systems. Docker creates simple tooling and a universal packaging approach that bundles up all application dependencies inside a container which is then run on Docker Engine. Docker Engine enables containerized applications to run anywhere consistently on any infrastructure, solving “dependency hell” for developers and operations teams, and eliminating the “it works on my laptop!” problem.	</p>	 				 				 				 				

<br>

<h3><b> Key Features and Capabilities</b></h3>
<p>Powered by containers<br>
Built on the leading open source container runtime, a graduated project of the Cloud Native Computing Foundation (CNCF). Containerd implements Kubernetes Container Runtime Interface (CRI) and is widely adopted across public clouds and enterprises.<br>

<em> Learn more: https://containerd.io/</em></p>
	 				

<h3><b> Integrated BuildKit</b> </h3>
<p> BuildKit is an open source tool that takes the instructions from a Dockerfile and ‘builds” a Docker image. This process can take a long time so BuildKit provides several architectural enhancements that makes it much faster, more precise and portable.<br>

<em> Learn more: https://docs.docker.com/develop/develop-images/build_enhancements/</em></p>


<h3><b> Docker CLI</b> </h3>
<p> The most popular way to interface with Docker containers is the Docker CLI – a simple, yet powerful client that greatly simplifies how you manage container instances through a clear set of commands.<br>

<em> Learn more: https://docs.docker.com/engine/reference/commandline/cli/</em></p>


