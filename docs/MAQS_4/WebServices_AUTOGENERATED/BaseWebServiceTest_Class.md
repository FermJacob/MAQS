# BaseWebServiceTest Class
 

Generic base web service test class


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;BaseTest<br />&nbsp;&nbsp;&nbsp;&nbsp;BaseExtendableTest(<a href="#/MAQS_4/WebServices_AUTOGENERATED/HttpClientWrapper_Class">HttpClientWrapper</a>, <a href="#/MAQS_4/WebServices_AUTOGENERATED/WebServiceTestObject_Class">WebServiceTestObject</a>)<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Magenic.MaqsFramework.BaseWebServiceTest.BaseWebServiceTest<br />
**Namespace:**&nbsp;<a href="#/MAQS_4/WebServices_AUTOGENERATED/Magenic-MaqsFramework-BaseWebServiceTest_Namespace">Magenic.MaqsFramework.BaseWebServiceTest</a><br />**Assembly:**&nbsp;Magenic.MaqsFramework.WebServiceTester (in Magenic.MaqsFramework.WebServiceTester.dll) Version: 4.0.4.0 (4.0.4)

## Syntax

**C#**<br />
``` C#
public class BaseWebServiceTest : BaseExtendableTest<HttpClientWrapper, WebServiceTestObject>
```

The BaseWebServiceTest type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="#/MAQS_4/WebServices_AUTOGENERATED/BaseWebServiceTest_Constructor">BaseWebServiceTest</a></td><td>
Initializes a new instance of the BaseWebServiceTest class. Setup the web service client for each test class</td></tr></table>&nbsp;
<a href="#basewebservicetest-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>Log</td><td> (Inherited from BaseTest.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>LoggedExceptionList</td><td> (Inherited from BaseTest.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td>LoggingEnabledSetting</td><td> (Inherited from BaseTest.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td>ObjectUnderTest</td><td> (Inherited from BaseExtendableTest(<a href="#/MAQS_4/WebServices_AUTOGENERATED/HttpClientWrapper_Class">HttpClientWrapper</a>, <a href="#/MAQS_4/WebServices_AUTOGENERATED/WebServiceTestObject_Class">WebServiceTestObject</a>).)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>PerfTimerCollection</td><td> (Inherited from BaseTest.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>SoftAssert</td><td> (Inherited from BaseTest.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>TestContext</td><td> (Inherited from BaseTest.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td>TestObject</td><td> (Inherited from BaseExtendableTest(<a href="#/MAQS_4/WebServices_AUTOGENERATED/HttpClientWrapper_Class">HttpClientWrapper</a>, <a href="#/MAQS_4/WebServices_AUTOGENERATED/WebServiceTestObject_Class">WebServiceTestObject</a>).)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="#/MAQS_4/WebServices_AUTOGENERATED/BaseWebServiceTest-WebServiceWrapper_Property">WebServiceWrapper</a></td><td>
Gets or sets the web service wrapper</td></tr></table>&nbsp;
<a href="#basewebservicetest-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>BeforeLoggingTeardown</td><td> (Inherited from BaseExtendableTest(<a href="#/MAQS_4/WebServices_AUTOGENERATED/HttpClientWrapper_Class">HttpClientWrapper</a>, <a href="#/MAQS_4/WebServices_AUTOGENERATED/WebServiceTestObject_Class">WebServiceTestObject</a>).)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="#/MAQS_4/WebServices_AUTOGENERATED/BaseWebServiceTest-CreateNewTestObject_Method">CreateNewTestObject</a></td><td>
Create a web service test object
 (Overrides BaseExtendableTest.CreateNewTestObject().)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/bsc2ak47" target="_blank">Equals</a></td><td>
Determines whether the specified object is equal to the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/4k87zsw7" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="#/MAQS_4/WebServices_AUTOGENERATED/BaseWebServiceTest-GetBaseWebServiceUrl_Method">GetBaseWebServiceUrl</a></td><td>
Get the base web service url</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>GetFullyQualifiedTestClassName</td><td> (Inherited from BaseTest.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/zdee4b3y" target="_blank">GetHashCode</a></td><td>
Serves as the default hash function.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="#/MAQS_4/WebServices_AUTOGENERATED/BaseWebServiceTest-GetHttpClient_Method">GetHttpClient</a></td><td>
Get the http client</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>GetResultText</td><td> (Inherited from BaseTest.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>GetResultType</td><td> (Inherited from BaseTest.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>GetSoftAssert</td><td> (Inherited from BaseTest.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/dfwy45w9" target="_blank">GetType</a></td><td>
Gets the <a href="http://msdn2.microsoft.com/en-us/library/42892f65" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>IsObjectUnderTestStored</td><td> (Inherited from BaseExtendableTest(<a href="#/MAQS_4/WebServices_AUTOGENERATED/HttpClientWrapper_Class">HttpClientWrapper</a>, <a href="#/MAQS_4/WebServices_AUTOGENERATED/WebServiceTestObject_Class">WebServiceTestObject</a>).)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>LogVerbose</td><td> (Inherited from BaseTest.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="#/MAQS_4/WebServices_AUTOGENERATED/BaseWebServiceTest-MapEvents_Method">MapEvents</a></td><td>
Map web service events to log events</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>PostSetupLogging</td><td> (Inherited from BaseExtendableTest(<a href="#/MAQS_4/WebServices_AUTOGENERATED/HttpClientWrapper_Class">HttpClientWrapper</a>, <a href="#/MAQS_4/WebServices_AUTOGENERATED/WebServiceTestObject_Class">WebServiceTestObject</a>).)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Setup</td><td> (Inherited from BaseExtendableTest(<a href="#/MAQS_4/WebServices_AUTOGENERATED/HttpClientWrapper_Class">HttpClientWrapper</a>, <a href="#/MAQS_4/WebServices_AUTOGENERATED/WebServiceTestObject_Class">WebServiceTestObject</a>).)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="#/MAQS_4/WebServices_AUTOGENERATED/BaseWebServiceTest-SetupEventFiringTester_Method">SetupEventFiringTester</a></td><td>
Setup the event firing web service wrapper and map the events to the logger
 (Overrides BaseExtendableTest.SetupEventFiringTester().)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>SetupLogging</td><td> (Inherited from BaseTest.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="#/MAQS_4/WebServices_AUTOGENERATED/BaseWebServiceTest-SetupNoneEventFiringTester_Method">SetupNoneEventFiringTester</a></td><td>
Setup the none event firing web service wrapper
 (Overrides BaseExtendableTest.SetupNoneEventFiringTester().)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Teardown</td><td> (Inherited from BaseExtendableTest(<a href="#/MAQS_4/WebServices_AUTOGENERATED/HttpClientWrapper_Class">HttpClientWrapper</a>, <a href="#/MAQS_4/WebServices_AUTOGENERATED/WebServiceTestObject_Class">WebServiceTestObject</a>).)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/7bxwbwt2" target="_blank">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>TryToLog</td><td> (Inherited from BaseTest.)</td></tr></table>&nbsp;
<a href="#basewebservicetest-class">Back to Top</a>

## See Also


#### Reference
<a href="#/MAQS_4/WebServices_AUTOGENERATED/Magenic-MaqsFramework-BaseWebServiceTest_Namespace">Magenic.MaqsFramework.BaseWebServiceTest Namespace</a><br />