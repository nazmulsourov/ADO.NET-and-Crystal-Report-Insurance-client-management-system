select * from newclient
select clientid,clientname,dateofbirth,contactno,clientemail,clientaddress,policyid,durationid,picture from newclient where clientid=8
update newclient set clientname='',dateofbirth='',contactno='',clientemail='',clientaddress='',policyid='',durationid='',picture='' where clientid=8
delete from newclient where clientid=1