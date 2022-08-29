system design@ back end

1.controller - response for recieving request from client side. in this case, i create 1 post function to deal with user research post request.

2.models - use to instantiate data object, in this app, the userinfo model mianly repersent the obstration of member information. inputs model and Dto model are
the input and output form of userinfo. the Dto model applied here is for sercurity reason which is:return data that only good enough to meet the requirement.

3.services - all the Business logical is handled by this layer,in this case it has only one method which is Searching user by policy number, repository service intereact with database and return the user which match the policy numbner

things can be improved on 

1.user login authentication.
2.apply ExceptionFilter to deal with exceptions.
3.apply interface for services and repository that make project easy to expand its new methods.
4.apply thread lock when the API require data rewrite action and heavly requested by many user.

