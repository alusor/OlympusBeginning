<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="notifications.aspx.cs" Inherits="notifications" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!--  page-wrapper -->
      <div id="page-wrapper">
            <div class="row">
                <!--  page header -->
                <div class="col-lg-12">
                    <h1 class="page-header">Notifications</h1>
                </div>
                 <!--end  page header -->
            </div>
            <div class="row">
                <div class="col-lg-6">
                     <!--  Alert Styles -->
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            Alert Styles
                        </div>
                        <div class="panel-body">
                            <div class="alert alert-success">
                                Lorem ipsum dolor sit amet, consectetur adipisicing elit. <a href="#" class="alert-link">Alert Link</a>.
                            </div>
                            <div class="alert alert-info">
                                Lorem ipsum dolor sit amet, consectetur adipisicing elit. <a href="#" class="alert-link">Alert Link</a>.
                            </div>
                            <div class="alert alert-warning">
                                Lorem ipsum dolor sit amet, consectetur adipisicing elit. <a href="#" class="alert-link">Alert Link</a>.
                            </div>
                            <div class="alert alert-danger">
                                Lorem ipsum dolor sit amet, consectetur adipisicing elit. <a href="#" class="alert-link">Alert Link</a>.
                            </div>
                        </div>
                    </div>
                    <!-- End Alert Styles -->
                </div>
                <div class="col-lg-6">
                    <!--  Dismissable Alerts -->
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            Dismissable Alerts
                        </div>
                        <div class="panel-body">
                            <div class="alert alert-success alert-dismissable">
                                <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                                Lorem ipsum dolor sit amet, consectetur adipisicing elit. <a href="#" class="alert-link">Alert Link</a>.
                            </div>
                            <div class="alert alert-info alert-dismissable">
                                <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                                Lorem ipsum dolor sit amet, consectetur adipisicing elit. <a href="#" class="alert-link">Alert Link</a>.
                            </div>
                            <div class="alert alert-warning alert-dismissable">
                                <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                                Lorem ipsum dolor sit amet, consectetur adipisicing elit. <a href="#" class="alert-link">Alert Link</a>.
                            </div>
                            <div class="alert alert-danger alert-dismissable">
                                <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                                Lorem ipsum dolor sit amet, consectetur adipisicing elit. <a href="#" class="alert-link">Alert Link</a>.
                            </div>
                        </div>
                    </div>
                     <!-- End Dismissable Alerts -->
                </div>
            </div>
            <div class="row">
                 <div class="col-lg-6">
                     <!--  Tooltips and Popovers-->
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            Tooltips Example 
                        </div>
                        <div class="panel-body">
                            <h4>Tooltip Demo</h4>
                            <div class="tooltip-demo">
                                <button type="button" class="btn btn-default margin-tips" data-toggle="tooltip" data-placement="left" title="Tooltip on left">Tooltip on left</button>
                                <button type="button" class="btn btn-default margin-tips" data-toggle="tooltip" data-placement="top" title="Tooltip on top">Tooltip on top</button>
                                <button type="button" class="btn btn-default margin-tips" data-toggle="tooltip" data-placement="bottom" title="Tooltip on bottom">Tooltip on bottom</button>
                                <button type="button" class="btn btn-default margin-tips" data-toggle="tooltip" data-placement="right" title="Tooltip on right">Tooltip on right</button>
                            </div>
                           
                        </div>
                    </div>
                     <!--End  Tooltips and Popovers-->
                </div>
                <div class="col-lg-6">
                     <!--  Tooltips and Popovers-->
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            Popovers Example 
                        </div>
                        <div class="panel-body">
                          
                            <h4>Clickable Popover Demo</h4>
                            <div class="tooltip-demo">
                                <button type="button" class="btn btn-default margin-tips" data-container="body" data-toggle="popover" data-placement="left" data-content="Vivamus sagittis lacus vel augue laoreet rutrum faucibus.">
                                    Popover on left
                                </button>
                                <button type="button" class="btn btn-default margin-tips" data-container="body" data-toggle="popover" data-placement="top" data-content="Vivamus sagittis lacus vel augue laoreet rutrum faucibus.">
                                    Popover on top
                                </button>
                                <button type="button" class="btn btn-default margin-tips" data-container="body" data-toggle="popover" data-placement="bottom" data-content="Vivamus sagittis lacus vel augue laoreet rutrum faucibus.">
                                    Popover on bottom
                                </button>
                                <button type="button" class="btn btn-default margin-tips" data-container="body" data-toggle="popover" data-placement="right" data-content="Vivamus sagittis lacus vel augue laoreet rutrum faucibus.">
                                    Popover on right
                                </button>
                            </div>
                        </div>
                    </div>
                     <!--End  Tooltips and Popovers-->
                </div>
            </div>
        </div>
        <!-- end page-wrapper -->
   
</asp:Content>

