﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelevantCodes.ExtentReports.View
{
    internal class Extent
    {
        public static string Source
        {
            get
            {
                return @"
                    @using RelevantCodes.ExtentReports;
                    @using RelevantCodes.ExtentReports.View;
                    @{var dateFormat = Model.ConfigurationMap[""dateFormat""];
                    var timeFormat = Model.ConfigurationMap[""timeFormat""];
                    var dateTimeFormat = Model.ConfigurationMap[""dateFormat""] + "" "" + Model.ConfigurationMap[""timeFormat""];
                    }
                    <!DOCTYPE html>
                    <html>
                        <head>
                            <!--
                                ExtentReports Librería 2.40.0 | http://relevantcodes.com/extentreports-for-selenium/ | https://github.com/anshooarora/
                                Copyright (c) 2015, Anshoo Arora (Relevant Codes) | Derechos de autor bajo la nueva licencia BSD | http://opensource.org/licenses/BSD-3-Clause
                                Documentación: http://extentreports.relevantcodes.com 
                            -->
                            <meta http-equiv='content-type' content='text/html; charset=@if (Model.ConfigurationMap != null && Model.ConfigurationMap.ContainsKey(""encoding"")) { @Raw(Model.ConfigurationMap[""encoding""]); };' /> 
                            <meta name='description' content='ExtentReports (by Anshoo Arora) es una librería para el reporte de tests automatizados realizada en .NET y Java. Podrás crear detallados y bonitos informes HTML para los navegadores más modernos. ExtentReports muestra los tests y los pasos en un dashboard realizado especialmente para un análisis simple y rápido de los resultados de las pruebas.' />
                            <meta name='robots' content='noodp, noydir' />
                            <meta name='viewport' content='width=device-width, initial-scale=1' />
                            <title>
                                @if (Model.ConfigurationMap != null && Model.ConfigurationMap.ContainsKey(""documentTitle""))
                                {                            
                                    @Raw(Model.ConfigurationMap[""documentTitle""])
                                }
                            </title>
                            <link rel='stylesheet' href='https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.2/css/materialize.min.css' type='text/css'>
                            <link href='https://cdn.rawgit.com/noelboss/featherlight/1.3.4/release/featherlight.min.css' type='text/css' rel='stylesheet' />
                            <link href='http://cdn.rawgit.com/anshooarora/extentreports/91d2454f7f15961cc3916d3cf9d8819027e17aab/cdn/extent.css' type='text/css' rel='stylesheet' />

                            <style>
                                @if (Model.ConfigurationMap != null && Model.ConfigurationMap.ContainsKey(""css""))
                                {
                                    @Raw(Model.ConfigurationMap[""styles""])
                                }
                            </style>
                        </head>
                        <body class='extent'>  
                            <nav>
                                <ul id='slide-out' class='side-nav fixed'>
                                    <li class='logo'>
                                        <a class='logo-content' href='http://extentreports.relevantcodes.com'><span>ExtentReports</span></a>
                                        <a class='menu-toggle right'><i class='mdi-navigation-menu'></i></a>
                                    </li> 
                                    <li class='analysis waves-effect active'><a href='#!' class='test-view'><i class='mdi-action-dashboard'></i>Detalles de tests</a></li>
                                    <li class='analysis waves-effect'><a href='#!' class='categories-view'><i class='mdi-maps-local-offer'></i>Categorías</a></li>
                                    <li class='analysis waves-effect'><a href='#!' class='dashboard-view'><i class='mdi-action-track-changes'></i></i>Análisis</a></li>
                                    <li class='analysis waves-effect'><a href='#!' class='testrunner-logs-view'><i class='mdi-action-assignment'></i>Log</a></li>
                                </ul>
                                <a href='#' data-activates='slide-out' class='button-collapse'><i class='mdi-navigation-menu'></i></a>
                                <span class='report-name'>@if (Model.ConfigurationMap != null && Model.ConfigurationMap.ContainsKey(""reportName"")) { @Raw(Model.ConfigurationMap[""reportName""]) }</span> <span class='report-headline'>@if (Model.ConfigurationMap != null && Model.ConfigurationMap.ContainsKey(""reportHeadline"")) { @Raw(Model.ConfigurationMap[""reportHeadline""]) }</span>
                                <ul class='right hide-on-med-and-down nav-right'>
                                    <li class='theme-selector' alt='Haga clic para cambiar al tema oscuro. Para habilitar de forma predeterminada, utilice la configuración js. $("".theme-selector"").click();' title='Haga clic para cambiar al tema oscuro. Para habilitar de forma predeterminada, utilice la configuración js $("".theme-selector"").click();'>
                                        <i class='mdi-hardware-desktop-windows'></i>
                                    </li>
                                    <li>
                                        <span class='suite-started-time'>@Model.StartTime.ToString(dateTimeFormat)</span>
                                    </li>
                                    <li>
                                        <span>v2.40.0</span>
                                    </li>
                                </ul>
                            </nav>
                            <div class='container'>
                                <div id='dashboard-view' class='row'>
                                    <div class='time-totals'>
                                        <div class='col l2 m4 s6'>
                                            <div class='card suite-total-tests'> 
                                                <span class='panel-name'>Tests totales</span> 
                                                <span class='total-tests'> <span class='panel-lead'></span> </span> 
                                            </div> 
                                        </div>
                                        <div class='col l2 m4 s6'>
                                            <div class='card suite-total-steps'> 
                                                <span class='panel-name'>Pasos totales</span> 
                                                <span class='total-steps'> <span class='panel-lead'></span> </span> 
                                            </div> 
                                        </div>
                                        <div class='col l4 m4 s12'>
                                            <div class='card suite-total-steps'> 
                                                <span class='panel-name'>Tiempo total insumido</span> 
                                                <span class='suite-total-time-taken panel-lead'>@Model.GetRunTime()</span> 
                                            </div> 
                                        </div>
                                        <div class='col l2 m6 s6 suite-start-time'>
                                            <div class='card green-accent'> 
                                                <span class='panel-name'>Comienzo</span> 
                                                <span class='panel-lead suite-started-time'>@Model.StartTime.ToString(dateTimeFormat)</span> 
                                            </div> 
                                        </div>
                                        <div class='col l2 m6 s6 suite-end-time'>
                                            <div class='card pink-accent'> 
                                                <span class='panel-name'>Fin</span> 
                                                <span class='panel-lead suite-ended-time'>@DateTime.Now.ToString(dateTimeFormat)</span> 
                                            </div> 
                                        </div>
                                    </div>
                                    <div class='charts'>
                                        <div class='col s12 m6 l4 fh'> 
                                            <div class='card-panel'> 
                                                <div>
                                                    <span class='panel-name'>Resultados de test</span>
                                                </div> 
                                                <div class='panel-setting modal-trigger test-count-setting right'>
                                                    <a href='#test-count-setting'><i class='mdi-navigation-more-vert text-md'></i></a>
                                                </div> 
                                                <div class='chart-box'>
                                                    <canvas class='text-centered' id='test-analysis'></canvas>
                                                </div> 
                                                <div>
                                                    <span class='weight-light'><span class='t-pass-count weight-normal'></span> Test(s) correcto(s)</span>
                                                </div> 
                                                <div>
                                                    <span class='weight-light'><span class='t-fail-count weight-normal'></span> Test(s) fallado(s), <span class='t-others-count weight-normal'></span> otro(s)</span>
                                                </div> 
                                            </div> 
                                        </div> 
                                        <div class='col s12 m6 l4 fh'> 
                                            <div class='card-panel'> 
                                                <div>
                                                    <span class='panel-name'>Resultados de pasos</span>
                                                </div> 
                                                <div class='panel-setting modal-trigger step-status-filter right'>
                                                    <a href='#step-status-filter'><i class='mdi-navigation-more-vert text-md'></i></a>
                                                </div> 
                                                <div class='chart-box'>
                                                    <canvas class='text-centered' id='step-analysis'></canvas>
                                                </div> 
                                                <div>
                                                    <span class='weight-light'><span class='s-pass-count weight-normal'></span> paso(s) correcto(s)</span>
                                                </div> 
                                                <div>
                                                    <span class='weight-light'><span class='s-fail-count weight-normal'></span> paso(s) fallado(s), <span class='s-others-count weight-normal'></span> otro(s)</span>
                                                </div> 
                                            </div> 
                                        </div>
                                        <div class='col s12 m12 l4 fh'> 
                                            <div class='card-panel'> 
                                                <span class='panel-name'>Porcentaje de test correctos</span> 
                                                <span class='pass-percentage panel-lead'></span> 
                                                <div class='progress light-blue lighten-3'> 
                                                    <div class='determinate light-blue'></div> 
                                                </div> 
                                            </div> 
                                        </div>
                                    </div>
                                    <div class='system-view'>
                                        <div class='col l4 m12 s12'>
                                            <div class='card-panel'>
                                                <span class='label info right'>Ambiente</span>
                                                <table>
                                                    <thead>
                                                        <tr>
                                                            <th>Parámetro</th>
                                                            <th>Valor</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
									                    @foreach (KeyValuePair<string, string> entry in Model.SystemInfo)
                                                        {
                                                            <tr>
                                                                <td>@entry.Key</td>
                                                                <td>@entry.Value</td>
                                                            </tr>
                                                        }
                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>
                                    </div>
                                    <div class='category-summary-view'>
                                        <div class='col l4 m6 s12'>
                                            <div class='card-panel'>
                                                <span class='label info right'>Categories</span>
                                                <table>
                                                    <thead>
                                                        <tr>
                                                            <th>Nombre</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        @if (Model.CategoryMap != null)
                                                        {
                                                            foreach (KeyValuePair<string, List<RelevantCodes.ExtentReports.Model.Test>> entry in Model.CategoryMap)
                                                            {
                                                                <tr>
                                                                    <td>@entry.Key</td>
                                                                </tr>
                                                            }
                                                        }
                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div id='test-view' class='row'>
                                    <div class='col s5'>
                                        <div class='card-panel heading'>
                                            <h5>Tests</h5>
                                        </div>
                                        <div class='card-panel filters'>
                                            <div>
                                                <a data-activates='tests-toggle' data-constrainwidth='true' data-beloworigin='true' data-hover='true' href='#' class='dropdown-button button tests-toggle'><i class='mdi-action-subject icon'></i></a>
                                                <ul id='tests-toggle' class='dropdown-content'>
                                                    <li class='pass'><a href='#!'>Correctos</a></li>
                                                    <li class='fail'><a href='#!'>Fallados</a></li>
                                                    @if (Model.TestList.Where(x => x.GetTest().Status.Equals(LogStatus.Fatal)).Count() > 0)
                                                    {
                                                        <li class='fatal'><a href='#!'>Fatal</a></li>
                                                    }
                                                    @if (Model.TestList.Where(x => x.GetTest().Status.Equals(LogStatus.Error)).Count() > 0)
                                                    {
                                                        <li class='error'><a href='#!'>Error</a></li>
                                                    }
                                                    @if (Model.TestList.Where(x => x.GetTest().Status.Equals(LogStatus.Warning)).Count() > 0)
                                                    {
                                                        <li class='warning'><a href='#!'>Atención</a></li>
                                                    }
                                                    <li class='skip'><a href='#!'>Omitido</a></li>
                                                    @if (Model.TestList.Where(x => x.GetTest().Status.Equals(LogStatus.Unknown)).Count() > 0)
                                                    {
                                                        <li class='unknown'><a href='#!'>Desconocido</a></li>
                                                    }
                                                    <li class='divider'></li>
                                                    <li class='clear'><a href='#!'>Borrar filtro</a></li>
                                                </ul>
                                            </div>                                            
                                            <div>
                                                <a data-activates='category-toggle' data-constrainwidth='false' data-beloworigin='true' data-hover='true' href='#' class='category-toggle dropdown-button button'><i class='mdi-image-style icon'></i></a>
                                                <ul id='category-toggle' class='dropdown-content'>
                                                    <li class='divider'></li>
                                                    @if (Model.CategoryMap != null)
                                                    {
                                                        foreach (KeyValuePair<string, List<RelevantCodes.ExtentReports.Model.Test>> entry in Model.CategoryMap)
                                                        {
                                                            <li class='@entry.Key'><a href='#!'>@entry.Key</a></li>
                                                        }
                                                    }
                                                    <li class='clear'><a href='#!'>Borrar filtro(s)</a></li>
                                                </ul>
                                            </div>
                                            <div>
                                                <a id='clear-filters' alt='Clear Filters' title='Clear Filters'><i class='mdi-navigation-close icon'></i></a>
                                            </div>
                                            <div>&nbsp;&middot;&nbsp;</div>
                                            <div>
                                                <a id='enableDashboard' alt='Activar Dashboard' title='Activar Dashboard'><i class='mdi-action-track-changes icon'></i></a>
                                            </div> 
                                            <div>
                                                <a id='refreshCharts' alt='Refrescar gráficos con filtro' title='Refrescar gráficos con filtro' class='enabled'><i class='mdi-navigation-refresh icon'></i></i></a>
                                            </div>
                                            <div>&nbsp;&middot;</div>
                                            <div class='search' alt='Buscar test(s)' title='Buscar test(s)'>
                                                <div class='input-field left'>
                                                    <input id='searchTests' type='text' class='validate' placeholder='Search tests...'>
                                                </div>
                                                <i class='mdi-action-search icon'></i>
                                            </div>
                                        </div>
                                        @{var vh100 = """";
                                            if (Model.TestList.Count < 15) {
                                                vh100 = ""vh100""; 
                                            }
                                        }
                                        <div class='card-panel no-padding-h no-padding-v @vh100'>
                                            <div class='wrapper'>
                                                <ul id='test-collection' class='test-collection'>
                                                    @foreach (var extentTest in Model.TestList)
                                                    {
                                                        var test = extentTest.GetTest();
                                                        <li class='collection-item test displayed active @test.Status.ToString().ToLower() @if(test.ContainsChildNodes){ <x> hasChildren </x> }' extentid='@test.ID'>
                                                            <div class='test-head'>
                                                                <span class='test-name'>@Raw(test.Name) @if (!String.IsNullOrEmpty(test.InternalWarning)) { <i class='tooltipped mdi-alert-error' data-position='top' data-delay='50' data-tooltip='@Raw(test.InternalWarning)'></i> }</span>
                                                                <span class='test-status right label capitalize outline @test.Status.ToString().ToLower()'>@test.Status.ToString().ToLower()</span>
                                                                <span class='category-assigned hide @test.GetCombinedCategories().ToLower()'></span>
                                                            </div>
                                                            <div class='test-body'>
                                                                <div class='test-info'>
                                                                    <span title='Comienzo del test' class='test-started-time label green lighten-2 text-white'>@test.StartTime.ToString(dateTimeFormat)</span>
                                                                    <span title='Fin de test' class='test-ended-time label red lighten-2 text-white'>@test.EndTime.ToString(dateTimeFormat)</span>
                                                                    <span title='Tiempo de ejecución' class='test-time-taken label blue-grey lighten-3 text-white'>@test.RunTime</span>
                                                                </div>
                                                                <div class='test-desc'>@Raw(test.Description)</div>
                                                                <div class='test-attributes'>
                                                                    @if (test.CategoryList != null && test.CategoryList.Count() > 0)
                                                                    {
                                                                        <div class='categories'>
                                                                        @foreach (var cat in test.CategoryList)
                                                                        {
                                                                            <span class='category'>@cat.Name</span>
                                                                        }
                                                                        </div>
                                                                    }
                                                                    @if (test.AuthorList != null && test.AuthorList.Count() > 0)
                                                                    {
                                                                        <div class='authors'>
                                                                        @foreach (var author in test.AuthorList)
                                                                        {
                                                                            <span class='author'>@author.Name</span>
                                                                        }
                                                                        </div>
                                                                    }
                                                                </div>
                                                                <div class='test-steps'>
                                                                    @if (test.LogList != null && test.LogList.Count() > 0)
                                                                    {
                                                                        <table class='bordered table-results'>
                                                                            <thead>
                                                                                <tr>
                                                                                    <th>Resultado</th>
                                                                                    <th>Hora</th>
                                                                                    @if (test.LogList[0].StepName != null)
                                                                                    {
                                                                                        <th>StepName</th>
                                                                                    }
                                                                                    <th>Detalle</th>
                                                                                </tr>
                                                                            </thead>
                                                                            <tbody>
                                                                                @foreach (var log in test.LogList)
                                                                                {
                                                                                    <tr>
                                                                                        <td class='status @log.LogStatus.ToString().ToLower()'><i class='@Icon.GetIcon(@log.LogStatus)'></i></td>" +
                                                                                        "<td class='timestamp'>@string.Format(\"{0:HH:mm:ss}\", log.Timestamp)</td>" +
                                                                                        @"@if (test.LogList[0].StepName != null)
                                                                                        {
                                                                                            <td class='step-name'>@Raw(log.StepName)</td>
                                                                                        }
                                                                                        <td class='step-details'>@Raw(log.Details)</td>
                                                                                    </tr>
                                                                                }
                                                                            </tbody>
                                                                        </table>
                                                                    }
                                                                    @if (test.ContainsChildNodes)
                                                                    {
                                                                        <ul class='collapsible node-list' data-collapsible='accordion'>
                                                                            @foreach (var node in test.NodeList)
                                                                            {
                                                                                <li class='displayed node-1x @node.Status.ToString().ToLower()' extentid='@node.ID'>
                                                                                    <div class='collapsible-header test-node @node.Status.ToString().ToLower()'>
                                                                                        <div class='right test-info'>
                                                                                            <span title='Hora de comienoz' class='test-started-time label green lighten-2 text-white'>@node.StartTime.ToString(dateTimeFormat)</span>
                                                                                            <span title='Hora de finalización' class='test-ended-time label red lighten-2 text-white'>@node.EndTime.ToString(dateTimeFormat)</span>
                                                                                            <span title='Tiempo de ejecución' class='test-time-taken label blue-grey lighten-2 text-white'>@node.RunTime</span>
                                                                                            <span class='test-status label capitalize @node.Status.ToString().ToLower()'>@node.Status.ToString().ToLower()</span>
                                                                                        </div>
                                                                                        <div class='test-node-name'>@Raw(node.Name)</div>
                                                                                        <div class='test-node-desc'>@Raw(node.Description)</div>
                                                                                    </div>
                                                                                    <div class='collapsible-body'>
                                                                                        <div class='test-steps'>
                                                                                            @if (node.LogList != null && node.LogList.Count() > 0)
                                                                                            {
                                                                                                <table class='bordered table-results'>
                                                                                                    <thead>
                                                                                                        <tr>
                                                                                                            <th>Resultado</th>
                                                                                                            <th>Hora</th>
                                                                                                            @if (node.LogList[0].StepName != null)
                                                                                                            {                                                
                                                                                                                <th>Nombre</th>
                                                                                                            }
                                                                                                            <th>Detalle</th>
                                                                                                        </tr>
                                                                                                    </thead>
                                                                                                    <tbody>
                                                                                                        @foreach (var log in node.LogList)
                                                                                                        {
                                                                                                            <tr>
                                                                                                                <td class='status @log.LogStatus.ToString().ToLower()'><i class='@Icon.GetIcon(@log.LogStatus)'></i></td>" +
                                                                                                                "<td class='timestamp'>@string.Format(\"{0:HH:mm:ss}\", log.Timestamp)</td>" +
                                                                                                                @"@if (node.LogList[0].StepName != null)
                                                                                                                {
                                                                                                                    <td class='step-name'>@Raw(log.StepName)</td>
                                                                                                                }
                                                                                                                <td class='step-details'>@Raw(log.Details)</td>
                                                                                                            </tr>
                                                                                                        }
                                                                                                    </tbody>
                                                                                                </table>
                                                                                            }
                                                                                        </div>
                                                                                    </div>
                                                                                </li>
                                                                            }
                                                                        </ul>
                                                                    }
                                                                </div>
                                                            </div>
                                                        </li>
                                                    }
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                    <div id='test-details-wrapper' class='col s7'>
                                        <div class='card-panel vh100 details-view pin'>
                                            <h5 class='details-name'></h5>
                                            <div class='details-container'>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div id='categories-view' class='row hide'>
                                    <div class='col s5'>
                                        <div class='card-panel heading'>
                                            <h5>Categorias</h5>
                                        </div>
                                        <div class='card-panel filters'>
                                            <div class='search' alt='Buscar test(s)' title='Buscar test(s)'>
                                                <div class='input-field left'>
                                                    <input id='searchTests' type='text' class='validate' placeholder='Search tests...'>
                                                </div>
                                                <i class='mdi-action-search icon'></i>
                                            </div>
                                        </div>
                                        <div class='card-panel no-padding-h no-padding-v vh100'>
                                            <div class='wrapper'>
                                                <ul id='cat-collection' class='cat-collection'>
                                                    @if (Model.CategoryMap != null)
                                                    {
                                                        foreach (KeyValuePair<string, List<RelevantCodes.ExtentReports.Model.Test>> entry in Model.CategoryMap)
                                                        {
                                                            var passed = entry.Value.Where(x => x.Status.Equals(LogStatus.Pass)).Count();
                                                            var failed = entry.Value.Where(x => x.Status.Equals(LogStatus.Fail)).Count();
                                                            var others = entry.Value.Count - (passed + failed);

                                                            <li class='category-item displayed @entry.Key.ToLower()'>
				                                                <div class='cat-head'>
					                                                <span class='category-name'>@entry.Key</span>
				                                                </div>
				                                                <div class='category-status-counts'>
                                                                    @if (passed > 0)
                                                                    {
					                                                    <span class='pass label dot'>Pass: @passed</span>
                                                                    }
                                                                    @if (failed > 0)
                                                                    {
					                                                    <span class='fail label dot'>Fail: @failed</span>
                                                                    }
                                                                    @if (others > 0)
                                                                    {
					                                                    <span class='other label dot'>Others: @others</span>
                                                                    }
				                                                </div>
				                                                <div class='cat-body'>
					                                                <div class='category-status-counts'>
						                                                <div class='button-group'>
                                                                            <a href='#!' class='pass label filter'>Pass <span class='icon'>@passed</span></a>
                                                                            <a href='#!' class='fail label filter'>Fail <span class='icon'>@failed</span></a>
                                                                            <a href='#!' class='other label filter'>Others <span class='icon'>@others</span></a>
                                                                        </div>
					                                                </div>
					                                                <div class='cat-tests'>
						                                                <table class='bordered'>
							                                                <thead>
								                                                <tr>
									                                                <th>Fecha de ejecución</th>
									                                                <th>Nombre del test</th>
									                                                <th>Resultado</th>
								                                                </tr>
							                                                </thead>
                                                                            <tbody>
                                                                                @foreach (var test in entry.Value)
                                                                                {
                                                                                    <tr>
                                                                                        <td>@test.StartTime.ToString(dateTimeFormat)</td>
                                                                                        <td><span class='category-link linked' extentid='@test.ID'>@test.Name</span></td>
                                                                                        <td><div class='status label outline capitalize @test.Status.ToString().ToLower()'>@test.Status</div></td>
                                                                                    </tr>
                                                                                }
                                                                            </tbody>
						                                                </table>
					                                                </div>
				                                                </div>
			                                                </li>
                                                        }
                                                    }
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                    <div id='cat-details-wrapper' class='col s7'>
                                        <div class='card-panel vh100 details-view pin'>
                                            <h5 class='cat-name'></h5>
                                            <div class='cat-container'>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div id='testrunner-logs-view' class='row hide'>
                                    <div class='col s12'>
                                        <div class='card-panel'>
                                            <h5>Log</h5>
                                            @foreach (var log in Model.TestRunnerLogs)
                                            {
                                                <p>@Raw(log)</p>
                                            }
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div id='test-count-setting' class='modal bottom-sheet'> 
                                <div class='modal-content'> 
                                    <h5>Configurar el tipo de vista</h5> 
                                    <input name='test-count-setting' type='radio' id='parentWithoutNodes' class='with-gap'> 
                                    <label for='parentWithoutNodes'>Solo test padres</label> 
                                    <br> 
                                    <input name='test-count-setting' type='radio' id='parentWithoutNodesAndNodes' class='with-gap'> 
                                    <label for='parentWithoutNodesAndNodes'>Test padres y test hijos</label> 
                                    <br> 
                                    <input name='test-count-setting' type='radio' id='childNodes' class='with-gap'> 
                                    <label for='childNodes'>Únicamente test hijos</label> 
                                </div> 
                                <div class='modal-footer'> 
                                    <a href='#!' class='modal-action modal-close waves-effect waves-green btn'>Save</a> 
                                </div> 
                            </div> 
                            <div id='step-status-filter' class='modal bottom-sheet'> 
                                <div class='modal-content'> 
                                    <h5>Seleccionar resultado</h5> 
                                    <input checked class='filled-in' type='checkbox' id='step-dashboard-filter-pass'> 
                                    <label for='step-dashboard-filter-pass'>Correctos</label> 
                                    <br> 
                                    <input checked class='filled-in' type='checkbox' id='step-dashboard-filter-fail'> 
                                    <label for='step-dashboard-filter-fail'>Fallados</label> 
                                    <br> 
                                    <input checked class='filled-in' type='checkbox' id='step-dashboard-filter-fatal'> 
                                    <label for='step-dashboard-filter-fatal'>Fatal</label> 
                                    <br> 
                                    <input checked class='filled-in' type='checkbox' id='step-dashboard-filter-error'> 
                                    <label for='step-dashboard-filter-error'>Error</label> 
                                    <br> 
                                    <input checked class='filled-in' type='checkbox' id='step-dashboard-filter-warning'> 
                                    <label for='step-dashboard-filter-warning'>Atención</label> 
                                    <br> 
                                    <input checked class='filled-in' type='checkbox' id='step-dashboard-filter-skip'> 
                                    <label for='step-dashboard-filter-skip'>Omitidos</label> 
                                    <br> 
                                    <input checked class='filled-in' type='checkbox' id='step-dashboard-filter-info'> 
                                    <label for='step-dashboard-filter-info'>Información</label> 
                                    <br> 
                                    <input checked class='filled-in' type='checkbox' id='step-dashboard-filter-unknown'> 
                                    <label for='step-dashboard-filter-unknown'>Desconocido</label> 
                                </div> 
                                <div class='modal-footer'> 
                                    <a href='#!' class='modal-action modal-close waves-effect waves-green btn'>Guardar</a> 
                                </div> 
                            </div>
                            <script src='https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js'></script> 
                            <script src='https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.2/js/materialize.min.js'></script>
                            <script src='https://cdnjs.cloudflare.com/ajax/libs/Chart.js/1.0.2/Chart.min.js'></script>
                            <script src='https://cdn.rawgit.com/noelboss/featherlight/1.3.4/release/featherlight.min.js' type='text/javascript' charset='utf-8'></script>
                            <script src='http://cdn.rawgit.com/anshooarora/extentreports/91d2454f7f15961cc3916d3cf9d8819027e17aab/cdn/extent.js' type='text/javascript'></script>

                            <script>$(document).ready(function() { $('.logo span').html('ExtentReports'); });</script>
                            <script>@if (Model.ConfigurationMap != null && Model.ConfigurationMap.ContainsKey(""scripts"")) { @Raw(Model.ConfigurationMap[""scripts""]) }</script>
                            
                        </body>
                    </html>
                    ";//.Replace("    ", "").Replace("\t", "").Replace("\r", "").Replace("\n", "");
            }
        }
    }
}
