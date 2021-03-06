﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Reflection;
using Linq2SqlGeography.LinqSql.FromOSS;


namespace Linq2SqlGeography
{
    public static class HandleTable
    {
        public static string createCellTracing
                        = @"

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CellTracing]') AND type in (N'U'))
DROP TABLE [dbo].[CellTracing]
;
CREATE TABLE [dbo].[CellTracing](
	[cell] [varchar](30) NULL,
	[MI_STYLE] [varchar](254) NULL,
	[MI_PRINX] [int] IDENTITY(1,1) NOT NULL,
	[SP_GEOMETRY] [geometry] NULL,
PRIMARY KEY CLUSTERED 
(
	[MI_PRINX] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
";
        public static string createEventLocating
                = @"

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EventLocating]') AND type in (N'U'))
DROP TABLE [dbo].[EventLocating]
;
CREATE TABLE [dbo].[EventLocating](
	[events] [varchar](30) NULL,
	[MI_STYLE] [varchar](254) NULL,
	[MI_PRINX] [int] IDENTITY(1,1) NOT NULL,
	[SP_GEOMETRY] [geometry] NULL,
PRIMARY KEY CLUSTERED 
(
	[MI_PRINX] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
";

        public static bool CreateTable(Type linqTableClass)
        {
            //handleTable.CreateTable(typeof(OpCiPDCH));

            bool suc = true;
            string createtable = linqTableClass.Name;
            //MessageBox.Show(createtable);
            //混淆以后反射名称被改变出现问题
            using (DataClasses1DataContext localdb = new DataClasses1DataContext())
            {
                try
                {
                    var metaTable = localdb.Mapping.GetTable(linqTableClass);
                    var typeName = "System.Data.Linq.SqlClient.SqlBuilder";
                    var type = typeof(DataContext).Assembly.GetType(typeName);
                    var bf = BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.InvokeMethod;
                    var sql = type.InvokeMember("GetCreateTableCommand", bf, null, null, new[] { metaTable });
                    string delSql = @"if exists (select 1 from  sysobjects where  id = object_id('dbo." + createtable + @"') and   type = 'U')
                            drop table dbo." + createtable;
                    localdb.ExecuteCommand(delSql.ToString());
                    localdb.ExecuteCommand(sql.ToString());
                }
                catch (Exception ex)
                {
                    suc = false;
                    Console.WriteLine(ex.ToString());
                    //MessageBox.Show(ex.ToString());
                }
            }
            return suc;
        }
        private static int red = 0;
        private static int green = 0;
        private static int blue = 0;
        private static Random random = new Random();
        public static int getRandomPenColor(bool r, bool g, bool b)
        {
            while (red < 200)
                red = random.Next() % 255;
            green = random.Next() % 255;
            blue = random.Next() % 255;
            if (r) red = 0;
            if (g) green = 0;
            if (b) blue = 0;
            return red * 65535 + green * 256 + blue;
        }
    }
}
