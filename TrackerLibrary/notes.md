#
## 09 - Prize Form Wire Up

CreatePrizeForm 表设计包含：

- 大标题 CreatePrize
- 奖项编号(placeNumberValue)
- 奖项名称(placeNameValue)
- 金额(prizeAmountValue)
- 百分比(prizePercentageValue)
- 创建奖项按钮 Create Prize

CreatePrizeForm 构造函数初始化组件。定义鼠标点击事件，对表单里的数据进行验证：

- 奖项编号必须为整数，且转换后的值不能小于 1
- 奖项名称的长度不能为 0
- 金额和百分比都必须能强制转换类型为小数
- 金额数值大于 0
- 百分比数值要大于等于 0，小于等于 100

如果验证通过，将管理员输入的四个值作为参数创建一个 PrizeModel 实例，将数据传入数据库，刷新面板上的值。如果验证失败，展示一个 MessageBox。

Program.cs -> GlobalConfig.cs, CreatePrizeForm.cs
## 10 - SQL Connection

在静态类 GlobalConfig 中创建了一个 IDataConnection 接口列表，IDataConnection 接口定义了要实现的函数 CreatePrize，并传入根据用户输入的表单数据创建的 model 实例，先前在主函数时就调用了静态函数对列表添加实例：

- SqlConnector
- TextConnector

SqlConnector 继承接口，实现了 CreatePrize，根据连接字符串 MyDatabaseConnection 实现数据库连接，执行数据插入存储过程，返回获取 id 的model。

CreatePrizeForm.cs -> 点击 Create 按钮 -> SqlConnector.cs
## 11 - Text Connection

在 app.config 里存储一个键值对用于保存文本文件的路径。

在 DataAccess 里创建类文件 TextConnectorProcessor：

- 创建扩展方法 FullFilePath 用于连接路径地址和文件名，返回完整的路径字符串
- 创建扩展方法 LoadFile 用于将文件内容加载到一个字符串列表中，如果文件不存在返回一个空的字符串，如果文件存在，则读取文件的所有行转换成列表返回
- 创建扩展方法 ConvertToPrizeModels 用于将一个字符串列表（文件中的每一行）转换为 PrizeModel 对象列表
- 创建扩展方法 SaveToPrizeFile 用于将 PrizeModel 对象的列表保存到指定的文件中

定义好方法后，在类文件 TextConnector 中执行函数。创建文件名 PrizeModels.csv，创建 CreatePrize 方法










## SqlConnector.cs 代码

> var p = new DynamicParameters();

这行代码创建了一个 DynamicParameters 对象 p，它是 Dapper 提供的一个用于管理存储过程参数的类。通过它可以灵活地添加各种参数（如输入、输出、返回值等）。

```cs
p.Add("@PlaceNumber", model.PlaceNumber);
p.Add("@PlaceName", model.PlaceName);
p.Add("@PrizeAmount", model.PrizeAmount);
p.Add("@PrizePercentage", model.PrizePercentage);
```

向 DynamicParameters 对象 p 中添加了输入参数。每个参数对应存储过程 dbo.spPrizes_Insert 需要的输入值。

> p.Add("id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

这一行代码添加了一个输出参数 id，它用于存储存储过程执行后返回的结果。

- id：表示新插入的记录的 Id，通常是数据库自动生成的主键。
- 0：为该参数提供一个初始值（通常输出参数的初始值是 0 或 null）。
- dbType: DbType.Int32：指定该参数的数据库类型是 Int32（32 位整数）。
- direction: ParameterDirection.Output：表示该参数是一个输出参数，用于从存储过程返回数据。

> connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

这一行代码使用 Dapper 的 Execute 方法来执行存储过程 dbo.spPrizes_Insert。它传递了三个参数：

- "dbo.spPrizes_Insert"：存储过程的名称。
- p：包含输入和输出参数的 DynamicParameters 对象。
- commandType: CommandType.StoredProcedure：指定执行的是存储过程。

Execute 方法将存储过程发送到数据库服务器，并执行它。

> p.Get<int>("@id");

从 p 中获取名为 @id 的参数，并将其转换为 int 类型。这个 id 是在存储过程执行后由数据库自动生成并返回的主键值。
### dbo.spPrizes_Insert 代码

```cs
USE [Tournaments]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spPrizes_Insert]
	@PlaceNumber int,
	@PlaceName nvarchar(50),
	@PrizeAmount money,
	@PrizePercentage float,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;
	
	insert into dbo.Prizes (PlaceNumber, PlaceName, PrizeAmount, PrizePercentage)
	values (@PlaceNumber,@PlaceName, @PrizeAmount, @PrizePercentage);
	
	select @id = SCOPE_IDENTITY();
END
```





























