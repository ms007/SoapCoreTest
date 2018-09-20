# SoapCore Test Solution

Use the following request to call the service

``` 
POST /Service.svc HTTP/1.1
Host: localhost:50144
Content-Type: text/xml
Cache-Control: no-cache

<soapenv:Envelope xmlns:soapenv="http://schemas.xmlsoap.org/soap/envelope/" xmlns:art="http://xmlns.xxx.xx/yy/artifact">
   <soapenv:Header/>
   <soapenv:Body>
      <art:getArtifactID>
         <email>mail@me.com</email>
      </art:getArtifactID>
   </soapenv:Body>
</soapenv:Envelope>
``` 
