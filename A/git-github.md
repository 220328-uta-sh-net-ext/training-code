
1. Git - Version Control System
2. Figure, big picture of committing and branching
3. History in 2005, and Linux, BitKeeper before Git
4. Git vs GitHub:                    
    - No need for internet for Git 
    - GitHub is a web service and hosts the Git repositories to easily collaborate with other people. It connects people and Git projects
5. Git is basically terminal based but there are GUIs for that as well, such as Github Desktop, Source Tree. The command line is faster. The commands are the same independent of the machine. Git is created as a command line tool and the documentation and most of the info online is based on the command line.
6. Windows Git Installation (Git Bash):
   - A bit trickier than on Mac because Git was designed for a unix-based interface (like Bash). The same creator for Linux and Git.
   - Bash is the command line interface for Linux and Mac (the default shell).
   - Git Bash emulates the same experience on a Windows machine. It comes with Git. 
   - STEP 1: Download git installer for Windows.
   - STEP 2: Leave the defaults in the installation EXCEPT one.
   - STEP 3: Use Visual Studio Code as Git’s default editor instead of Vim
   - STEP 4: Before next it needs to install Visual Studio Code. Check add to path and Register code as an editor…
   - STEP 5: Let Git decide the default branch name.
   - STEP 6: Everything else is default.
   - STEP 7: To see if Git is installed in the terminal type: git –version
7. Mac Git installation:
   - Most mac systems come with Git pre-installed.
   - We are using some new syntax that the older versions don’t contain so you wanna make sure that you are using version 2.23 and above.  Check git –version in terminal. In case you wanna install follow the steps
   - STEP 1: Download for macOS
   - STEP 2: Use binary installer
   - STEP 3: Go to security and privacy of system preferences.
   - STEP 4: In general use open Anyway for the git installer

8. Configuring Git:
   - Use your developer (GitHub) name
   - Use your GitHub email address
   - git config –global user.name “Sample Name”
   - Check the name using: git config user.name
   - User.email for the email address


9. Terminal crash course: 
   - ls : list content of the directory
   - Home directory specified by ~ 
   - open .  : on Mac opens a file explorer or finder in the same directory where I am
   - start .  : equivalent to open on Windows.
   - ls folder_name : to see the content of the folder
   - open folder_name in Mac or start folder_name in Windows
   - Path to access files or folders inside other folders.
   - pwd  : print working directory
   - cd  : change directory
   - cd ..  : to go back
   - touch file_name1 file_name2 : create file or files
   - mkdir  : make directory
   -  rm file_name  : remove file(s) permanently
   - rm -rf folder_name  : remove folder permanently

## The Very Basics of Git: Adding & Committing
   1. Repo: is a workspace which tracks and manages files within a folder. Every Git repo has its own history and is not connected to others. 
   2. git status: It reports the status of the current repository.
   3. git init: Initializes a new repo wherever we are in the terminal. Create a directory called .git . Use ls -a to see the hidden files. .git has the history of the repo. To remove it to remove the history you can type rm -rf .git  Then the current directory won’t be a git repo anymore.
   4. Git tracks a directory and all the (nested) subdirectories. We DO NOT want to run git init inside an existing repository! Git gets confused. When you run git init make sure you are not in a repository. So, first check git status.
   5. One repo per project. In case of having nested repos, get rid of that by deleting one of the .git folders. 
   6. Committing: The most important git feature. Checkpoint along with a message. More than just saving, this is a point we can come back to later on. Multi-step process. Therefore selectively make commits. You can call out some of the changes you have made in some files and group them together when you are committing. Select certain changes and make a commit with those changes. Two commands for committing: git add, git commit . Select the files you want to stage, the changes you want to stage using add, then commit. 
   7. Create MyFirstGitRepo
   8. Create sample1.txt and sample2.txt and check the status
   9. Add sample1.txt and check the status to see the message and the different colors. Then add sample2.txt in a new step and check the status again.
   10. Then modify a file and add a new file to the repo and use git add and git status again.
   11. Working directory: the current directory
   12. Staging area: after git add, not a physical location
   13. Repository: after each commit the files and folders are here. You are updating the .git folder after each git commit
   14. git add: git add file1 file2
   1. git add . will stage all the changes
   15. git commit: We need to provide a commit message. Should summarize the changes. 
    - If you just use git commit it is going to use your default editor. In Windows we set the default editor in GitBash installation to VSCode.
    - Mac users need to configure the default editor so they should avoid git commit before that.
    - The git commit -m “my message” allows you to pass in an inline commit message, rather than launching a text editor. 
    - git commit without -m will expect you to add a message in a separate step.
    - git commit -a -m “my message” to add and commit for all the unstaged changes at the same time.
   16. git log: retrieves info of the commits. Author, email, date, commit message. And commit hash
   17. To open the current folder in VSCode use code . in the terminal. 
        - For Mac follow this: https://stackoverflow.com/questions/30065227/run-open-vscode-from-mac-terminal

## Basic Git and commands
- `cd 'path'` -> change directory
- `cd ..` -> moves a level up
	- use arrow keys to see history of previously use commands
	- history -> gives a track of all commands you have used in the current session
- `cd ./ tab key` -> gives the auto-completion of the file/directory
- `ls` -> list all the files and directories
- `mkdir 'directory name'` -> make directory
- `touch 'file name.extension'` -> creates a file
- `git clone 'url'` -> adds the local workspace in your machine
- `git add <filename>` -> adds the file you target to add to git
- `git add -A` -> adds all the file
- `git commit -m 'message'` -> Stage changes and commit to git as a new node
- `git push` -> push changes to git server
- `git status` -> see the new tracks/ changes made in local workspace
- `git pull` -> retrieve changes from the git server (updates your workspace with latest code)
- `pwd` -> print where directory