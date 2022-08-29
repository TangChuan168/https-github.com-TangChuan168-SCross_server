system design@ back end
1.controller - response for recieving request from client side.

2.models - use to instantiate data object, in this app, the userinfo model mianly repersent the obstration of member information. inputs model and Dto model are
the input and output form of userinfo. the Dto model applied here is for sercurity reason which is:return data that only good enough to meet the requirement.

3.services - all the Business logical is handled by this layer,in this case it has only one method which is Searching user by policy number, repository service intereact with database and return the user which match the policy numbner


