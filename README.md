# MyTask - HOMEWORK PROJECT
###TASK MANAGEMENT SYSTEM

Technologies which will be used for this project are:
-Microsoft ASP.NET MVC Framework
-Microsoft SQL Server Database
-HTML/CSS
-JavaScript/jQuery/Ajax
-Implementation of Repository pattern


#Project Features

1. User Authentication
  * User can log in on the system with username and password
2. User Registration
  * User can register on the system. But should be then activated by Administrator
3. User Reset Password
	*User can reset password by providing username. Password reset link should be sent over email.
4. Dashboard with Listing Projects
  * On dashboard, you should list all the projects.
5. Listing tasks for selected project
	Tasks should be grouped in 4 vertical columns:
    * To Do
    * In Progress
    * In Testing (QA)
    * Done	
6. I can change task status - Rules: 
    * Task from To Do can go to In Progress or In Testing (QA) but not to Done
    * Task from In Progress can go to To Do, In Testing (QA) or Done
    * Task from In Testing (QA) can go in To Do or Done, but not to In Progress
    * Task from Done can’t go back to any other status
7. Add/Update/Delete Task
8. Add/Update/Delete Project
9. There should be two roles in the system: Administrator and User
  * Administrator can add new users in the system
  * Administrator can add new projects in the system
  * Administrator can add new customers in the system
  * Administrator can activate newly registered users
  * User and Administrator can add new tasks on project
10. Show basic report of total number of tasks per user where you should list all users and total number of tasks assigned to that user.


#Bonus Features
1. If more than 20 projects, please provide pagination feature.
2. If implemented draggable and droppable way of updating status of tasks. Example: If task is in To Do column, with drag-and-drop with mouse I can move it to In Progress column.
3. Add/Update/Delete Task implemented using jQuery Ajax
4. Add/Update/Delete Project implemented using jQuery Ajax
5. Reports which will be shown to be printable
6. Put it hole project on Azure with DB
