# 0 - Title Slide

* Interest in security on the web
* Big part and quite applicable is web application security
* Plan on potentially doing a series of these presentations, oriented around the OWASP top 10
* Hopefully won't be too boring, and apologies if you already know what I'm about to say 

# 1 - XSS
 
## 1.0
 
* Item 3 in the OWASP top 10 (didn't cover SQL injection which is #1)
 
## 1.1 Types
 
* Server - prerendered HTML already contains the malicious script
    * e.g. ASP.NET MVC
    
* Client - A JavaScript call after the page has loaded injects malicious script into the page
    * e.g. search page with a querystring and the page shows the search term which could be done by JavaScript
    * or an XHR request which popoulates part of the DOM
    
## 1.2 Demo

Explain about the bookstore, place for comments, everyone anonymous or logged in can view the comments

## 1.3 Scripts

* Explain header tag
* Explain style attributes => seems harmless but it's wrong -> server is sending markup to browser and browser has no way of knowing that review is not meant to be treated as markup
* Style => affects entire page! breaking out of the review box now.
* Script => defacing site. LOGIN BEFORE DOING NEXT ONE
* Script => stealing logon info. Could show in incognito mode

## 1.5 Prevention

Point 3
* CSP - instructs the browser where styles/scripts/fonts etc should be loaded from. Browser won't load them from anywhere else.
* Content-types - stops browsers sniffing content . e.g. user profile pictures - upload a script
* X-XSS-Protefction - enforces the browsers XSS detection filter if it has been disabled by user. Note: only detects client XSS
* Cookies HTTP only - prevents JavaScript from reading cookies

# 2 - CSRF

## 2.1 Demo

Make sure you sign in to the bookstore

## 2.2 A Closer Look

Explain the page URL is win-lots-of-money

## 2.3.2

stress that it's because the attacker knew what needed sending back to the server 
the attacker needs to craft the malicious form that is to be submitted.

# 2.3.3

Also could check the referer header, or origin header and challenge-response (i.e. captcha)