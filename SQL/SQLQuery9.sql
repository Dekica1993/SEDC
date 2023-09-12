alter procedure dbo.InsertOrders(

@OrderDate date,
@BussinessEntityId int,
@CustomerId int,
@EmployeeId int,
@Comment nvarchar(max)
)
as 
begin

begin try

insert into dbo.Orders(OrderDate,BusinessEntityId,CustomerId,EmployeeId,Comment)
values (@OrderDate,@BussinessEntityId,@CustomerId,@EmployeeId,@Comment)

end try


begin catch

select ERROR_LINE() as err_line, ERROR_MESSAGE() as err_msg, ERROR_NUMBER()as err_numb, ERROR_PROCEDURE()as err_sp, ERROR_SEVERITY() as err_severity, ERROR_STATE()as err_state


end catch


end


--exec dbo.InsertOrders '2023-06-01',100,1,1,'Test Error handling'


exec dbo.InsertOrders '2023-06-01',7,1,1,'Test Error handling'

select *
from dbo.Orders
where OrderDate = '2023-06-01'



