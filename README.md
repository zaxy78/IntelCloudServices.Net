Intel Cloud Services SDK for .Net 
==========

This is a Portable Library of C# Client for the Intel Cloud Services: http://software.intel.com/cloudservicesplatform/home

This Portable Library is in early Alpha:  *** still won't work ***
Results May Vary. 

What's a Portable Library? 
=========
Portable library is a .NET binary lib (dll) compatible with few different platforms.

This IntelCS.Net Protable Library is compatible with .NET4, .NET 4.5, Win8 Apps & Windows Phone 7.5 and 8.
For this to work, Visual Studio combines the biggest set of APIs - which is common to all platforms.

Try It!

Usage is as follows :


            IntelCloudServices icsClient; 
            icsClient = new IntelCloudServices( "{api_client}" );

            // authenticate this app with the Clous Services
            var result = icsClient.init();
            

And more & more methods to come. updates every commit.
