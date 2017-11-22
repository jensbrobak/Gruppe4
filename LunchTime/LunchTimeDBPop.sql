use LunchTimeDb
go

insert into Customers values(1, 0, 'joe@mail.com', 'Joe Smith', 123);

insert into Products values('Jordbær lagkage', 'Lagkage', 12.50, 8);
insert into Products values('Sandwtch med kylling og beacon', 'Sandwitch', 15.50, 10);
insert into Products values('Sandwtch med tunsalat', 'Sandwitch', 15.50, 6);
insert into Products values('Sandwich med røget laks', 'Sandwitch', 15.50, 4);
insert into Products values('Sandwich med ribbensteg', 'Sandwitch', 15.50, 2);
insert into Products values('Toast med skinke og ost', 'Toast', 7.0, 9);
insert into Products values('Krydret tomat pizza', 'Pizza', 35.50, 15);

insert into Orders values(1, 1, '2017-11-03 17:59:05', 1);

insert into OrderItem values(1, 1, 1, 2);
insert into OrderItem values(2, 1, 3, 3);
