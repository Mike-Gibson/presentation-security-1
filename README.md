# Security Presentation 1

In order to run the presentation:

1. Edit hosts file - add

        127.0.0.1 unnamed-bookstore.com
        127.0.0.1 win-lots-of-money.com

2. Open `code/Security1.sln` in Visual Sdtudio **AS ADMIN**
3. Run the site in Visual Studio

    **NOTE:** You may need to edit the file `C:\Users\<username>\My Documents\IISExpress\config\applicationhost.config`:
    
    Replace the appropriate binding(s) with:   
    
    ```
    <binding protocol="http" bindingInformation="*:62331:unnamed-bookstore.com" />
    <binding protocol="http" bindingInformation="*:62331:win-lots-of-money.com" />
    ```
    
4. Open `presentation/index.html`
