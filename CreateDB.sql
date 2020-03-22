use CityFest

--create table dbo.Participant
--(
--	ParticipantId int not null identity(1,1) primary key,
--	ParticipantEmail varchar(70) not null,
--	ParticipantFirstName nvarchar(30) not null,
--	ParticipantSecondName nvarchar(50) not null,
--	ParticipantPhone nvarchar(13) not null,
--	ParticipantActivity nvarchar(100) not null
--);

--go

--set identity_insert dbo.Participant off;

--insert into dbo.Participant(ParticipantEmail, ParticipantFirstName, ParticipantSecondName, ParticipantPhone, ParticipantActivity)
--values 
--	('garik@gmail.com', 'Garik', 'Harlamov', '+380884756744', 'ёморист')

select * from dbo.Participant