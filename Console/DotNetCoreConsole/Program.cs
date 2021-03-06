﻿using CodeLibraryForDotNetCore;
using CodeLibraryForDotNetCore.SendEmail;
using CodeLibraryForDotNetCore.UsePostgresql;
using CodeLibraryForDotNetCore.UseYield;
using CoreConsole;
using System;
using System.Threading.Tasks;
using CodeLibraryForDotNetCore.Extensions1;
using CodeLibraryForDotNetCore.Extensions2;
using IsNullOrEmptyCustomExtension= CodeLibraryForDotNetCore.Extensions2.StringExtension2;
using CodeLibraryForDotNetCore.LinqTools;
using CodeLibraryForDotNetCore.GenerateRegularExpressionByCode.UseCSharpVerbalExpressions;
using CodeLibraryForDotNetCore.UseTcpSocket;
using CodeLibraryForDotNetCore.UseArray;
using CodeLibraryForDotNetCore.StringConverters;
using CodeLibraryForDotNetCore.UseRabbitMQ;
using CodeLibraryForDotNetCore.IPAddresses;
using System.Collections;
using CodeLibraryForDotNetCore.Algorithms;
using CodeLibraryForDotNetCore.Algorithms.Enums;
using System.Reflection;
using CodeLibraryForDotNetCore.UseEqualsAndHashCodes;
using CodeLibraryForDotNetCore.UseString;
using CodeLibraryForDotNetCore.UseConstAndReadonly;
using CodeLibraryForDotNetCore.DelegateAndEvent;
using CodeLibraryForDotNetCore.DelegateAndEvent.Delegate;
using CodeLibraryForDotNetCore.DelegateAndEvent.Event;
using CodeLibraryForDotNetCore.UseDependencyInjection;

namespace DotNetCoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //redis
            //RedisDemo.Run();

            //postgresql
            //Task.Run(async () =>
            //{
            //    await (new UsePostgresqlDemo(new TestDbContextFactory().CreateDbContext(args))).Run();
            //});

            //read config
            //ConfigReadDemo.ReadConfig();
            //ConfigReadDemo.ReadConfigByBind();
            //ConfigReadDemo.ReadConfigHotUpdate();
            //ConfigReadDemo.ReadConfig2();

            //send email
            //SendEmailDemo.Run();

            //yield
            //UseYieldDemo.Run();

            //扩展方法同名
            //var str = "Test Extensions";
            //bool r1= CodeLibraryForDotNetCore.Extensions2.StringExtension2.IsNullOrEmptyCustomExtension(str);
            //bool r2= CodeLibraryForDotNetCore.Extensions1.StringExtension1.IsNullOrEmptyCustomExtension(str);
            //如果同时引用了两个命名空间，无法写的效果
            //bool r = str.IsNullOrEmptyCustomExtension();

            //Postgresql 使用空间数据
            //Task.Run(async () =>
            //{
            //    await (new PostgresqlUseGeometryDemo(new TestDbContextFactory().CreateDbContext(args))).Run();
            //});

            //linq 使用lambda表达式
            //new LinqToolDemo(new TestDbContextFactory().CreateDbContext(args)).Run();

            //使用代码动态生成正则表达式
            //UseCSharpVerbalExpressionsDemo.Run();

            //tcp socket demo
            //UseTcpSocketDemo.Run();

            //数组
            //UseArrayDemo.Run();

            //byte to string
            //StringDemo.Run();

            //RabbitMQ Sender
            //var host = "localhost";
            //var port = 5673;
            //var userName = "guest";
            //var password = "guest";
            //Send.Run(host, port, userName, password);
            //NewTask.Run(host, port, userName, password);
            //EmitLog.Run(host, port, userName, password);

            //获得IPAddress列表
            //IPAddressTool.GetIPAddressList();

            //排序算法：https://www.cnblogs.com/onepixel/articles/7674659.html
            //var sortList1 = BubbleSort.Sort(new int[] { 2,33,22,1,0,9,5},SortMethodEnum.FromLargeToSmall);
            //var sortList2 = BubbleSort.Sort(new int[] { 2, 33, 22, 1, 0, 9, 5 }, SortMethodEnum.FromSmallToLarge);

            //var sortList3 = SelectionSort.Sort(new int[] { 2, 33, 22, 1, 0, 9, 5 }, SortMethodEnum.FromLargeToSmall);
            //var sortList4 = SelectionSort.Sort(new int[] { 2, 33, 22, 1, 0, 9, 5 }, SortMethodEnum.FromSmallToLarge);

            //hash code
            //UseEqualsAndHashCodesDemo.TestHashCode();
            //UseEqualsAndHashCodesDemo.TestEquals();

            //string
            //UseStringDemo.Run();
            //UseStringDemo.Run2();

            //const && readonly
            //var demo = new UseConstAndReadonlyDemo();

            //委托和事件
            //DelegateDemo.DelegateDemo1();
            //DelegateDemo.DelegateDemo2();
            //DelegateDemo.DelegateDemo3();
            //DelegateDemo.DelegateDemo4();
            //EventDemo.Run();

            //依赖注入
            var demo = new UseDependencyInjectionDemo();
            demo.Run("依赖注入测试...");

            Console.ReadLine();
        }

        ~Program()
        {

        }
    }
}
