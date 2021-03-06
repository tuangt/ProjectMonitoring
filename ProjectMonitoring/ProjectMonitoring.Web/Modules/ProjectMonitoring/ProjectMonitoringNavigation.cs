﻿using Serenity.Navigation;
using MyPages = ProjectMonitoring.ProjectMonitoring.Pages;
using Administration = ProjectMonitoring.Administration.Pages;


[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "",
    icon: "fa-tachometer")]

[assembly: NavigationMenu(2000, "ProjectMonitoring", icon: "fa-code")]
[assembly: NavigationLink(2100, "ProjectMonitoring/Account", typeof(Administration.UserController), icon: "fa-user")]
[assembly: NavigationLink(2200, "ProjectMonitoring/Posts", typeof(MyPages.PostsController), icon: "fa-align-left")]
[assembly: NavigationLink(2300, "ProjectMonitoring/Classes", typeof(MyPages.ClassesController), icon: "fa-graduation-cap")]
[assembly: NavigationLink(2400, "ProjectMonitoring/Subjects", typeof(MyPages.SubjectsController), icon: "fa-book")]
[assembly: NavigationLink(2500, "ProjectMonitoring/SCMs", typeof(MyPages.SCMsController), icon: "fa-link")]
[assembly: NavigationLink(2600, "ProjectMonitoring/SCMTypes", typeof(MyPages.SCMTypesController), icon: "fa-github-square")]



