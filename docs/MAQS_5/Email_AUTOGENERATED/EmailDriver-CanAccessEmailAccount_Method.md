# EmailDriver.CanAccessEmailAccount Method 
 

Check if the account is accessible

**Namespace:**&nbsp;<a href="MAQS_5/Email_AUTOGENERATED/Magenic-Maqs-BaseEmailTest_Namespace">Magenic.Maqs.BaseEmailTest</a><br />**Assembly:**&nbsp;Magenic.Maqs.BaseEmailTest (in Magenic.Maqs.BaseEmailTest.dll) Version: 5.3.0

## Syntax

**C#**<br />
``` C#
public virtual bool CanAccessEmailAccount()
```


#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a><br />True if the email account is accessible

## Examples

**C#**<br />
``` C#
[TestMethod]
[TestCategory(TestCategories.Email)]
public void CanAccessEmail()
{
    Assert.IsTrue(this.EmailDriver.CanAccessEmailAccount(), "Email account was not accessible");
}
```


## See Also


#### Reference
<a href="MAQS_5/Email_AUTOGENERATED/EmailDriver_Class">EmailDriver Class</a><br /><a href="MAQS_5/Email_AUTOGENERATED/Magenic-Maqs-BaseEmailTest_Namespace">Magenic.Maqs.BaseEmailTest Namespace</a><br />