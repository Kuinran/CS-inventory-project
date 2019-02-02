# CS-inventory-project

This program is meant to be an experiment in using C# for a windows UWP application with 
a handbuilt GUI and practising the integration of My SQL into a program.

The goals and functionality intended to be implemented are the following:
• Store all application information in a centralized source/database
• Implement basic client/server architecture
• Allow users to add, remove, update resources and their relevant location
* Allow users to schedule resources to different events/locations
* Prevent resource scheduling conflicts
* Validate the data being entered
* Include checklists of items/tasks that need to be accomplished for certain resources to be scheduled (ex: flight needs to be booked to arrive at the X location)
* Users should be able to export the scheduling information as well as the information that needs to be sent to a resources (ex: PDF, simple text...)
* Notify the resource of scheduling changes (doesn't actually need to send out a notification but playing with different systems is always a bonus).
* Different notification delays should be configurable (ex: days before sending out a reminder)
* Optionally, an authentication system can be implemented
