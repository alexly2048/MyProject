* 开发环境
    1. Visual Studio 2017 Community
    2. .NET Framework
* 类库
    1. Dapper
    2. Autofac
    3. Winform
* 说明：
    该项目为个人开发的考试系统，数据存储使用SQL Server数据库，通过Dapper对数据进行查询。
根据用户录入的数据，通过随机抽取题目中题目，形成试卷。用户完成考试后，系统可以自动评分并
记录考试信息。
    项目使用Winform实现，通过自定义控件，实现不同题目的显示。项目中使用了Autoface进行依赖
注入控制，通过依赖注入实现方法的调用。