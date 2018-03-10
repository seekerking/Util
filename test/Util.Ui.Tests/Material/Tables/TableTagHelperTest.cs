﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using Util.Helpers;
using Util.Ui.Configs;
using Util.Ui.Material.Enums;
using Util.Ui.Material.Tables.TagHelpers;
using Util.Ui.Tests.XUnitHelpers;
using Xunit;
using Xunit.Abstractions;
using String = Util.Helpers.String;

namespace Util.Ui.Tests.Material.Tables {
    /// <summary>
    /// 表格测试
    /// </summary>
    public class TableTagHelperTest {
        /// <summary>
        /// 输出工具
        /// </summary>
        private readonly ITestOutputHelper _output;
        /// <summary>
        /// 表格
        /// </summary>
        private readonly TableTagHelper _component;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public TableTagHelperTest( ITestOutputHelper output ) {
            _output = output;
            _component = new TableTagHelper();
            Id.SetId( "id" );
        }

        /// <summary>
        /// 获取结果
        /// </summary>
        private string GetResult( TagHelperAttributeList contextAttributes = null, TagHelperAttributeList outputAttributes = null, TagHelperContent content = null ) {
            return Helper.GetResult( _output, _component, contextAttributes, outputAttributes, content );
        }

        /// <summary>
        /// 测试默认输出
        /// </summary>
        [Fact]
        public void TestDefault() {
            var result = new String();  
            result.Append( "<mat-table-wrapper #m_id=\"\">" );
            result.Append( "<mat-table matSort=\"\" matSortDisableClear=\"\" [dataSource]=\"m_id.dataSource\" " );
            result.Append( "[style.max-height]=\"m_id.maxHeight?m_id.maxHeight+'px':null\" " );
            result.Append( "[style.min-height]=\"m_id.minHeight?m_id.minHeight+'px':null\">" );
            result.Append( "</mat-table>" );
            result.Append( "</mat-table-wrapper>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试添加标识
        /// </summary>
        [Fact]
        public void TestId() {
            var attributes = new TagHelperAttributeList { { UiConst.Id, "a" } };
            var result = new String();
            result.Append( "<mat-table-wrapper #a=\"\">" );
            result.Append( "<mat-table matSort=\"\" matSortDisableClear=\"\" [dataSource]=\"a.dataSource\" " );
            result.Append( "[style.max-height]=\"a.maxHeight?a.maxHeight+'px':null\" " );
            result.Append( "[style.min-height]=\"a.minHeight?a.minHeight+'px':null\">" );
            result.Append( "</mat-table>" );
            result.Append( "</mat-table-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( attributes ) );
        }

        /// <summary>
        /// 测试查询参数
        /// </summary>
        [Fact]
        public void TestQueryParam() {
            var attributes = new TagHelperAttributeList { { UiConst.QueryParam, "a" } };
            var result = new String();
            result.Append( "<mat-table-wrapper #m_id=\"\" [queryParam]=\"a\">" );
            result.Append( "<mat-table matSort=\"\" matSortDisableClear=\"\" [dataSource]=\"m_id.dataSource\" " );
            result.Append( "[style.max-height]=\"m_id.maxHeight?m_id.maxHeight+'px':null\" " );
            result.Append( "[style.min-height]=\"m_id.minHeight?m_id.minHeight+'px':null\">" );
            result.Append( "</mat-table>" );
            result.Append( "</mat-table-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( attributes ) );
        }

        /// <summary>
        /// 测试基地址
        /// </summary>
        [Fact]
        public void TestBaseUrl() {
            var attributes = new TagHelperAttributeList { { UiConst.BaseUrl, "a" } };
            var result = new String();
            result.Append( "<mat-table-wrapper #m_id=\"\" baseUrl=\"a\">" );
            result.Append( "<mat-table matSort=\"\" matSortDisableClear=\"\" [dataSource]=\"m_id.dataSource\" " );
            result.Append( "[style.max-height]=\"m_id.maxHeight?m_id.maxHeight+'px':null\" " );
            result.Append( "[style.min-height]=\"m_id.minHeight?m_id.minHeight+'px':null\">" );
            result.Append( "</mat-table>" );
            result.Append( "</mat-table-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( attributes ) );
        }

        /// <summary>
        /// 测试排序
        /// </summary>
        [Fact]
        public void TestSort() {
            var attributes = new TagHelperAttributeList { { UiConst.Sort, "a" } };
            var result = new String();
            result.Append( "<mat-table-wrapper #m_id=\"\">" );
            result.Append( "<mat-table matSort=\"\" matSortActive=\"a\" matSortDisableClear=\"\" [dataSource]=\"m_id.dataSource\" " );
            result.Append( "[style.max-height]=\"m_id.maxHeight?m_id.maxHeight+'px':null\" " );
            result.Append( "[style.min-height]=\"m_id.minHeight?m_id.minHeight+'px':null\">" );
            result.Append( "</mat-table>" );
            result.Append( "</mat-table-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( attributes ) );
        }

        /// <summary>
        /// 测试排序方向
        /// </summary>
        [Fact]
        public void TestSortDirection() {
            var attributes = new TagHelperAttributeList { { UiConst.SortDirection, SortDirection.Desc } };
            var result = new String();
            result.Append( "<mat-table-wrapper #m_id=\"\">" );
            result.Append( "<mat-table matSort=\"\" matSortDirection=\"desc\" matSortDisableClear=\"\" [dataSource]=\"m_id.dataSource\" " );
            result.Append( "[style.max-height]=\"m_id.maxHeight?m_id.maxHeight+'px':null\" " );
            result.Append( "[style.min-height]=\"m_id.minHeight?m_id.minHeight+'px':null\">" );
            result.Append( "</mat-table>" );
            result.Append( "</mat-table-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( attributes ) );
        }
    }
}