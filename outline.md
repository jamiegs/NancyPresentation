- Introduction
	- Everytime I go to write a .NET web application I directly go to ASP.NET MVC, but I wanted to check out what else is out there.

	- What is nancy
		- First commit in April 2011
		- Started by Andreas Håkansson (thecodejunkie), and Steven Robbins (grumpydev)
		- Based on Ruby's sinatra which is a lightweight substitute for rails.
		- Opinionated, yet flexible, you can override the conventions or create your own conventions.

	- It has support for many of the well known frameworks, and more get added all the time.
	- The pluggable nature makes it pretty easy to add your own framework in.

- Super-duper-happy-path 
	- Just works
		- It automatically discovers things for you.
		- For most things you should be able ot just add the library and it's ready to use

	- Easily customizable
		- There should be no barriers to get in the way of customization.

	- Low ceremony
		- Nancy should stay out of the way for the most part.
		- Minimal Amount of nancy code to write

	- Low friction
		- Obvious conventions like view folder name, or model names
		- Minimal required configuration

- Demo
	- Run as administrator

	1) Create console applicaition, change to .net 4 client profile
	Name it NancyPresentation

	2) Nuget 
	install-package nancy.hosting.self

	==Api==

	3) add bootstrapper and models

	4) add module.

	==Html==

	5) add views
		Remember to change build action to content and copy to output to always

	6) add css
	Remember to change build action to content and copy to output to always

	Demo Web
		localhost:12345
	Demo Api
		Show xml 
		Show json


	==Testing==

	7) add project

	Nuget 
		for test project
	install-package nancy.testing

	8) add boot strapper

	9) add unit tests.
		unit tests

- With result in module, you can return serveral things, a View, a string, a model (will figure it's view out, a httpresponse)

- Why use it
	- Need to have a web interface in a existing application
	- Run it on mono or raspberry pi

Conclusion
	- interesting.
	- somewhat of a learning curve
	- feels a bit ridged
	- I think when it has potential
	- would look again when it hits version 1.0 

	- had issue where HTTP and JSON worked for a model, but not XML, reason was the model was private. Took a long time to figure out.

	- really like it for creating APIs