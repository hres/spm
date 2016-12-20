<%@ Page Title="" Language="C#"  AutoEventWireup="true" CodeBehind="titlePage.aspx.cs" Inherits="StructuredProductMonograph.titlePage" ValidateRequest="false"  %>
<!DOCTYPE html>
<!--[if lt IE 9]><html class="no-js lt-ie9" lang="en" dir="ltr"><![endif]--><!--[if gt IE 8]><!-->
<html class="no-js" lang="en" dir="ltr">
<!--<![endif]-->
<head runat="server"> 
    <meta charset="utf-8">
    <!-- Web Experience Toolkit (WET) / Boîte à outils de l'expérience Web (BOEW)
    wet-boew.github.io/wet-boew/License-en.html / wet-boew.github.io/wet-boew/Licence-fr.html -->
    <title>Drug Health Product Registry Form</title>
    <meta content="width=device-width,initial-scale=1" name="viewport">
    <!-- Meta data -->
    <meta name="dcterms.language" title="ISO639-2" content="eng" />
    <meta name="dcterms.title" content="Drug Health Product Registry Form" />
    <meta name="description" content="Find the latest results from the Government's good pharmacovigilance practices (GVP) inspections." />
    <meta name="dcterms.subject" title="scheme" content="" />
    <meta name="dcterms.creator" content="Government of Canada, Health Canada and the Public health Agency of Canada" />
    <meta name="dcterms.contributor" content="" />
    <meta name="dcterms.type" title="gctype" content="" />
    <meta name="dcterms.audience" title="gcaudience" content="" />
    <meta name="dcterms.issued" title="W3CDTF" content="2016-03-09" />
    <meta name="dcterms.modified" title="W3CDTF" content="2016-03-09" />
    <meta name="review_date" content="" />
    <meta name="meta_date" content="" />
    <!-- Meta data-->
    <script src="http://cdn.tinymce.com/4/tinymce.min.js"></script>
    <script>
           function scrollToContent (){window.location.hash="wb-cont";}
           function noScrollToContent() { }
    </script>
    <!--[if gte IE 9 | !IE ]><!-->
    <link href="/distro/4.0.20/GCWeb/assets/favicon.ico" rel="icon" type="image/x-icon">
    <link rel="stylesheet" href="/distro/4.0.20/GCWeb/css/theme.min.css">
    <!--<![endif]-->
    <!--[if lt IE 9]>
    <link href="/distro/4.0.20/GCWeb/assets/favicon.ico" rel="shortcut icon" />

    <link rel="stylesheet" href="/distro/4.0.20/GCWeb/css/ie8-theme.min.css" />
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
    <script src="/distro/4.0.20/wet-boew/js/ie8-wet-boew.min.js"></script>
    <![endif]-->
    <!--[if lte IE 9]>
    <![endif]-->
    <!--Start Healthy Canadians CSS-->
    <link rel="stylesheet" href="/spmAssets/css/hcans.css" />
    <!--End Healthy Canadians CSS--><!-- CUSTOM SCRIPTS/CSS START | DEBUT DES SCRIPTS/CSS PERSONNALISES -->
    <!-- CUSTOM SCRIPTS/CSS END | FIN DES SCRIPTS/CSS PERSONNALISES -->
    <noscript><link rel="stylesheet" href="/distro/4.0.20/wet-boew/css/noscript.min.css" /></noscript>
    <!-- Google Tag Manager DO NOT REMOVE OR MODIFY - NE PAS SUPPRIMER OU MODIFIER -->
    <script>dataLayer1 = [];</script>
    <!-- End Google Tag Manager -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.4/jquery.js"></script>
   <script src="/spmAssets/js/pmp.js"></script>
   <script src="/spmAssets/js/coverPage.js"></script> 
   <link rel="stylesheet" href="//code.jquery.com/ui/1.12.0/themes/base/jquery-ui.css">
   <script src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.11.4/jquery-ui.min.js"></script>
   <script>
      $(document).ready(function () {
           $("#tabs").tabs();
           //tinyMCE.init({
           //    mode: "textareas",
           //    editor_deselector: "mceNoEditor"
           //});
       });
      </script> 
   </head>
<body vocab="http://schema.org/" typeof="WebPage" class="secondary">
    <!-- Google Tag Manager DO NOT REMOVE OR MODIFY - NE PAS SUPPRIMER OU MODIFIER -->
    <noscript><iframe title="Google Tag Manager" src="//www.googletagmanager.com/ns.html?id=GTM-TLGQ9K" height="0" width="0" style="display:none;visibility:hidden"></iframe></noscript>
    <script>(function(w,d,s,l,i){w[l]=w[l]||[];w[l].push({'gtm.start': new Date().getTime(),event:'gtm.js'});var f=d.getElementsByTagName(s)[0], j=d.createElement(s),dl=l!='dataLayer1'?'&l='+l:'';j.async=true;j.src='//www.googletagmanager.com/gtm.js?id='+i+dl;f.parentNode.insertBefore(j,f);})(window,document,'script','dataLayer1','GTM-TLGQ9K');</script>
    <!-- End Google Tag Manager -->
    <ul id="wb-tphp">
        <li class="wb-slc">
            <a class="wb-sl" href="#wb-cont">Skip to main content</a>
        </li>
        <li class="wb-slc visible-sm visible-md visible-lg">
            <a class="wb-sl" href="#wb-info">Skip to "About this site"</a>
        </li>
    </ul>
    <header role="banner">
        <div id="wb-bnr" class="container">
            <section id="wb-lng" class="visible-md visible-lg text-right">
                <h2 class="wb-inv">Language selection</h2>
                <div class="row">
                    <div class="col-md-12">
                        <ul class="list-inline margin-bottom-none">
                            <li><a lang="fr" href="index-fr.html">Français</a></li>
                        </ul>
                    </div>
                </div>
            </section>
            <div class="row">
                <div class="brand col-xs-8 col-sm-9 col-md-6">
                    <a href="http://www.canada.ca/en/index.html"><object type="image/svg+xml" tabindex="-1" data="/distro/4.0.20/GCWeb/assets/sig-blk-en.svg"></object><span class="wb-inv"> Government of Canada</span></a>
                </div>
                <section class="wb-mb-links col-xs-4 col-sm-3 visible-sm visible-xs" id="wb-glb-mn">
                    <h2>Search and menus</h2>
                    <ul class="list-inline text-right chvrn">
                        <li><a href="#mb-pnl" title="Search and menus" aria-controls="mb-pnl" class="overlay-lnk" role="button"><span class="glyphicon glyphicon-search"><span class="glyphicon glyphicon-th-list"><span class="wb-inv">Search and menus</span></span></span></a></li>
                    </ul>
                    <div id="mb-pnl"></div>
                </section>
                <section id="wb-srch" class="col-xs-6 text-right visible-md visible-lg">
                    <h2>Search</h2>
                    <form action="http://recherche-search.gc.ca/rGs/s_r?#wb-land" method="get" name="cse-search-box" role="search" class="form-inline">
                        <script type="text/javascript" src="https://www.google.com/jsapi"></script>
                        <script type="text/javascript">
var autoCompletionOptions = { 'validLanguages' : 'en', };
		google.load( 'search', '1');
		google.setOnLoadCallback( function() {google.search.CustomSearchControl.attachAutoCompletionWithOptions( '008724028898028201144:knjjdikrhq0', document.getElementById( 'wb-srch-q' ), 'cse-search-box', autoCompletionOptions );});
		google.setOnLoadCallback( function() {setTimeout( function(){google.search.CustomSearchControl.attachAutoCompletionWithOptions( '008724028898028201144:knjjdikrhq0', document.getElementById( 'wb-srch-q-imprt' ), 'cse-search-box',autoCompletionOptions );}, 2000);});</script>
                        <div class="form-group">
                            <label for="wb-srch-q" class="wb-inv">Search website</label>
                            <input name="cdn" value="canada" type="hidden" />
                            <input name="st" value="s" type="hidden" />
                            <input name="num" value="10" type="hidden" />
                            <input name="langs" value="eng" type="hidden" />
                            <input name="st1rt" value="0" type="hidden">
                            <input name="s5bm3ts21rch" value="x" type="hidden" />
                            <input id="wb-srch-q" class="wb-srch-q form-control" name="q" type="search" value="" size="27" maxlength="150" placeholder="Search Canada.ca" />
                        </div>
                        <div class="form-group submit">
                            <button type="submit" id="wb-srch-sub" class="btn btn-primary btn-small" name="wb-srch-sub"><span class="glyphicon-search glyphicon"></span><span class="wb-inv">Search</span></button>
                        </div>
                    </form>
                </section>
            </div>
        </div>
        <nav role="navigation" id="wb-sm" class="wb-menu visible-md visible-lg" data-trgt="mb-pnl" data-ajax-replace="//cdn.canada.ca/gcweb-cdn-live/sitemenu/sitemenu-en.html" typeof="SiteNavigationElement">
            <div class="container nvbar">
                <h2>Topics menu</h2>
                <div class="row">
                    <ul class="list-inline menu">
                        <li><a href="http://www.esdc.gc.ca/en/jobs/index.page">Jobs</a></li>
                        <li><a href="http://www.cic.gc.ca/english/index.asp">Immigration</a></li>
                        <li><a href="http://travel.gc.ca">Travel</a></li>
                        <li><a href="http://www.canada.ca/en/services/business/index.html">Business</a></li>
                        <li><a href="http://www.canada.ca/en/services/benefits/index.html">Benefits</a></li>
                        <li><a href="http://healthycanadians.gc.ca/index-eng.php">Health</a></li>
                        <li><a href="http://www.canada.ca/en/services/taxes/index.html">Taxes</a></li>
                        <li><a href="http://www.canada.ca/en/services/index.html">More services</a></li>
                    </ul>
                </div>
            </div>
        </nav>
        <nav role="navigation" id="wb-bc" property="breadcrumb">
            <h2>You are here:</h2>
            <div class="container">
                <div class="row">
                    <ol class="breadcrumb">
                        <li><a href="http://canada.ca/en/index.html">Home</a></li>
                        <li><a href="http://healthycanadians.gc.ca/index-eng.php">Health</a></li>
                        <li><a href="http://healthycanadians.gc.ca/drugs-products-medicaments-produits/index-eng.php">Drug and health products</a></li>
                        <li><a href="http://healthycanadians.gc.ca/drugs-products-medicaments-produits/inspecting-monitoring-inspection-controle/index-eng.php">Inspecting and monitoring drug and health products</a></li>
                        <li><a href="http://healthycanadians.gc.ca/drugs-products-medicaments-produits/inspecting-monitoring-inspection-controle/inspections/index-eng.php">Drug and health product inspections</a></li>
                    </ol>
                </div>
            </div>
        </nav>
    </header>

<div class="container">
    <main role="main" property="mainContentOfPage" class="container">
    <h1 property="name" id="wb-cont">Drug and health product register - product monograph form</h1>           
          <div id="tabs">                
               <ul>
                <li><a href="#tabs-1">Title page</a></li>
                <li><a href="#tabs-2">Product</a></li>
                <li><a href="#tabs-3">Part I</a></li>
                <li><a href="#tabs-4">Part II</a></li>
                <li><a href="#tabs-5">Part III</a></li>
                <li><a href="#tabs-6">XML View</a></li>
              </ul>       	              
                
             <div class="wb-frmvld">
                <form id="productMonograph" name="productMonograph" runat="server"> 
                <asp:ScriptManager id="ScriptManager1" runat="server" EnablePageMethods="true"></asp:ScriptManager>
                <div class="row">
                    <div class="col-sm-9">
                       <%-- <p class="mrgn-bttm-sm"><strong><span class="field-name">Brand name:</span></strong>
                            <asp:Literal ID="brandName" runat="server"></asp:Literal>
                        </p>
                        <p><strong><span class="field-name">Proper name:</span></strong>
                            <asp:Literal ID="properName" runat="server" ></asp:Literal>
                        </p>--%>
                    </div>
                    <div class="col-sm-3 text-right">
                        <asp:Button ID="btnSaveDraft" runat="server" CssClass="btn btn-primary"  ToolTip="Please save your form data in a draft file." OnClick="btnSaveDraft_Click"  />  
                       
<%--                    <input type="submit" value="Save" class="btn btn-primary" ToolTip="Please save your form data in a draft file."/>--%>
                         <input type="reset" value="Reset" class="btn btn-default mrgn-lft-sm">
                    </div>
               </div>
<!--Title Page--> 
<div class="panel panel-default" id="tabs-1">
    <div class="panel-heading">
          <h2 class="panel-title">Title Page</h2>
    </div>    
    <div class="panel-body">
        <div class="row hidden">       
            <input id="Button3" type="button" value="Hide" />
            <input id="Button4" type="button" value="Show" />
        </div>
        <div class="form-group row mrgn-bttm-sm">
                <label for="title" class="control-label col-sm-3 required"><span class="field-name">Title</span></label> 
                <div class="col-sm-9"> 
                    <asp:TextBox id="title" runat="server"  CssClass="form-control full-width input-sm"  ClientIDMode="Static" required="required"></asp:TextBox>                                
                </div>
            </div>
            <div class="form-group row mrgn-bttm-sm">
                <label for="version" class="control-label col-sm-3 required"><span class="field-name">Version</span></label> 
                <div class="col-sm-9"> 
                   <asp:TextBox id="version" runat="server"  CssClass="form-control input-sm"  ClientIDMode="Static" required="required" type="number" min="-1" max="1" step="0.1"></asp:TextBox>                        
                </div>
            </div>
            <div class="form-group row mrgn-bttm-sm">
                <label for="language" class="control-label col-sm-3 required"><span class="field-name">Language</span></label> 
                <div class="col-sm-9"> 
                    <select class="form-control input-sm" id="language" name="language" required="required">
				        <option label="Select a language"></option>
				        <option value="eng">English</option>
				        <option value="fra">Franch</option>
			        </select>                               
                </div>
            </div>
           <details class="mrgn-bttm-sm">
           <summary id="companyAddress" class="well well-sm">Sponsor Information</summary>
               <div class="form-group mrgn-bttm-0">
			    <label for="sponsorRegistry" class="mrgn-bttm-0"><span class="field-name">Sponsor registry(1.31)</span> </label>
                <select class="form-control input-sm" id="sponsorRegistry" name="sponsorRegistry">
				        <option label="Select a sponsor registry"></option>
				        <option value="???">No value yet</option>
			    </select> 
		      </div>
              <div class="form-group mrgn-bttm-0">
			    <label for="comID" class="mrgn-bttm-0"><span class="field-name">Company ID(1.33)</span> </label>
                <asp:TextBox id="comID" runat="server"  CssClass="form-control input-sm mrgn-tp-0"  ClientIDMode="Static"  pattern=".{2,}" data-rule-minlength="2" ></asp:TextBox>                                
		      </div>             
               <div class="form-group mrgn-bttm-0">
			    <label for="comName" class="required"><span class="field-name">Company name</span> </label>
                <asp:TextBox id="comName" runat="server"  CssClass="form-control input-sm mrgn-tp-0"  ClientIDMode="Static"  required="required" pattern=".{2,}" data-rule-minlength="2" ></asp:TextBox>                                
		      </div>
              <div class="form-group mrgn-bttm-0">
			    <label for="street" class="required mrgn-bttm-0"><span class="field-name">Street</span></label>
		        <asp:TextBox id="street" runat="server"  CssClass="form-control full-width input-sm"  ClientIDMode="Static"  required="required" pattern=".{2,}" data-rule-minlength="2" ></asp:TextBox>                                
             </div>
              <div class="form-group mrgn-bttm-0">
			    <label for="city" class="required mrgn-bttm-0"><span class="field-name">City</span></label>
                <asp:TextBox id="city" runat="server"  CssClass="form-control input-sm"  ClientIDMode="Static"  required="required" pattern=".{2,}" data-rule-minlength="2" ></asp:TextBox>                                
		      </div>             
              <div class="form-group mrgn-bttm-0">
			    <label for="province" class="required mrgn-bttm-0"><span class="field-name">Province</span></label>
                <asp:TextBox id="province" runat="server"  CssClass="form-control input-sm"  ClientIDMode="Static"  required="required" pattern=".{2,}" data-rule-minlength="2" ></asp:TextBox>                                
		      </div>
              <div class="form-group mrgn-bttm-0">
			    <label for="country" class="required mrgn-bttm-0"><span class="field-name">Country</span></label>
		        <asp:TextBox id="country" runat="server"  CssClass="form-control input-sm"  ClientIDMode="Static"  required="required" pattern=".{2,}" data-rule-minlength="2" ></asp:TextBox>                                
              </div>
              <div class="form-group mrgn-bttm-0">
			     <label for="postalCode" class="required mrgn-bttm-0"><span class="field-name">Postal code</span></label>
		      	 <asp:TextBox id="postalCode" runat="server"  CssClass="form-control input-sm"  ClientIDMode="Static"  required="required" size="7" maxlength="7"  data-rule-postalCodeCA="true"></asp:TextBox>                                
              </div>              
              <div class="form-group mrgn-bttm-0">
			        <label for="phone" class="required mrgn-bttm-0"><span class="field-name">Telephone number</span></label>
                  	<asp:TextBox id="phone" runat="server"  CssClass="form-control input-sm"  ClientIDMode="Static"  required="required" data-rule-phoneUS="true" type="tel"></asp:TextBox>                                
               </div>
              <div class="form-group mrgn-bttm-0">
			        <label for="email" class="required mrgn-bttm-0"><span class="field-name">Email address</span> (yourname@domain.com)</label>
			        <asp:TextBox id="email" runat="server"  CssClass="form-control input-sm"  ClientIDMode="Static"  required="required" type="email"></asp:TextBox>                                
		        </div>
              <div class="form-group mrgn-bttm-0">
			    <label for="firstName" class="required mrgn-bttm-0"><span class="field-name">First name</span></label>
		      	<asp:TextBox id="firstName" runat="server"  CssClass="form-control input-sm"  ClientIDMode="Static"  required="required" pattern=".{2,}" data-rule-minlength="2" ></asp:TextBox>                                
              </div>
              <div class="form-group mrgn-bttm-0">
			    <label for="lastName" class="required mrgn-bttm-0"><span class="field-name">Last name</span></label>
			    <asp:TextBox id="lastName" runat="server"  CssClass="form-control input-sm"  ClientIDMode="Static"  required="required" pattern=".{2,}" data-rule-minlength="2" ></asp:TextBox>                                
		      </div>
         </details>
           <details class="mrgn-bttm-sm">
           <summary id="agentAddress" class="well well-sm">Other Party Information</summary>
              <div id="AgentAddress">
                  <div class="form-group row mrgn-bttm-0">
                      <div class="col-sm-10">
			            <label for="agentComName" class="mrgn-bttm-0"><span class="field-name">Company name</span> </label>
                        <input class="form-control input-sm" id="agentComName" name="agentComName" pattern=".{2,}" data-rule-minlength="2" />
		              </div>
                      <div class="col-sm-2 text-right"> 
                           <input class="btn btn-default btn-xs" type="button" value="Add" onclick="AddAgenetAddress()" id="btnAgenetAddress" />
                       </div> 
                  </div>
                  <div class="form-group mrgn-bttm-0">
			        <label for="agentComID" class="mrgn-bttm-0"><span class="field-name">Company ID(1.33)</span> </label>
                       <input class="form-control input-sm" id="agentComID" name="agentComID" pattern=".{2,}" data-rule-minlength="2" />
		          </div>
                  <div class="form-group mrgn-bttm-0">
			        <label for="agentOrganizationRole" class="mrgn-bttm-0"><span class="field-name">Organization role(1.35)</span> </label>
                        <select class="form-control input-sm" id="agentOrganizationRole" name="agentOrganizationRole">
				                <option label="Select an organization role"></option>
				                <option value="???">No value yet</option>
			            </select> 
		          </div>
                  <div class="form-group ">
			        <label for="agentStreet" class="mrgn-bttm-0"><span class="field-name">Street</span></label>
                 	<input class="form-control input-sm full-width" id="agentStreet" name="agentStreet" pattern=".{2,}" data-rule-minlength="2" />
                  </div>
                  <div class="form-group mrgn-bttm-0">
			        <label for="agentCity" class="mrgn-bttm-0"><span class="field-name">City</span></label>
		            <input class="form-control input-sm" id="agentCity" name="agentCity" pattern=".{2,}" data-rule-minlength="2" />
		          </div>             
                  <div class="form-group mrgn-bttm-0">
			        <label for="agentProvince" class="mrgn-bttm-0"><span class="field-name">Province</span></label>
		            <input class="form-control input-sm" id="agentProvince" name="agentProvince" pattern=".{2,}" data-rule-minlength="2" />
                  </div>
                  <div class="form-group mrgn-bttm-0">
			        <label for="agentCountry" class="mrgn-bttm-0"><span class="field-name">Country</span></label>
                    <input class="form-control input-sm" id="agentCountry" name="agentCountry" pattern=".{2,}" data-rule-minlength="2" />
                  </div>
                  <div class="form-group mrgn-bttm-0">
			         <label for="agentPostalCode" class="mrgn-bttm-0"><span class="field-name">Postal code</span></label>
                     <input class="form-control input-sm" id="agentPostalCode" name="agentPostalCode" size="7" maxlength="7"  data-rule-postalCodeCA="true"/>
                  </div>              
                  <div class="form-group mrgn-bttm-0">
			            <label for="agentPhone" class="mrgn-bttm-0"><span class="field-name">Telephone number</span></label>
                  		<input class="form-control input-sm" id="agentPhone" name="agentPhone" data-rule-phoneUS="true" type="tel"/>
                  </div>
                  <div class="form-group mrgn-bttm-0">
			            <label for="agentEmail" class="mrgn-bttm-0"><span class="field-name">Email address</span> (yourname@domain.com)</label>
		                <input class="form-control input-sm" id="agentEmail" name="agentEmail" type="email"/>
                  </div>
                  <div class="form-group mrgn-bttm-0">
			        <label for="agentFirstName" class="mrgn-bttm-0"><span class="field-name">First name</span></label>
                  	<input class="form-control input-sm" id="agentFirstName" name="agentFirstName" type="text" pattern=".{2,}" data-rule-minlength="2" />
                  </div>
                  <div class="form-group mrgn-bttm-0">
			        <label for="agentLastName" class="mrgn-bttm-0"><span class="field-name">Last name</span></label>
			        <input class="form-control input-sm" id="agentLastName" name="agentLastName" type="text" pattern=".{2,}" data-rule-minlength="2" />
		          </div>
              </div>
              <div id="divExtrAgentAddress"></div>
         </details>
        <%--  <div class="form-group mrgn-bttm-sm">
                <label for="titleBlock" class="mrgn-bttm-0"><span class="field-name">Title Block</span></label> 
                <textarea id="titleBlock" name="titleBlock" runat="server" class="textarea form-control mrgn-tp-0"  ClientIDMode="Static"></textarea>  
            </div>        --%>   
                  
            <div class="form-group mrgn-bttm-sm">
                 <label for="pharmaceuticalStandard" class="mrgn-bttm-0"><span class="field-name">Pharmaceutical Standard</span></label> 
                 <div class="row mrgn-lft-sm">
                    <asp:DropDownList ID="pharmaceuticalStandard" CssClass="form-control input-sm col-sm-3" runat="server" ClientIDMode="Static"></asp:DropDownList>
                    <input class="btn btn-default btn-xs mrgn-lft-sm"  type="button" value="Add" onclick="AddPharmaceuticalStandard()" id="PharmaceuticalStandard" />
                </div>
            </div>
            <div id="extraPS"></div> 
            <div class="form-group mrgn-bttm-sm">
                <label for="therapeuticClassification" class="mrgn-bttm-0"><span class="field-name">Therapeutic Classification</span></label> 
                <div class="row mrgn-lft-sm">
                    <asp:DropDownList ID="therapeuticClassification" CssClass="form-control input-sm col-sm-3" runat="server" ClientIDMode="Static"></asp:DropDownList>
                    <input class="btn btn-default btn-xs mrgn-lft-sm"  type="button" value="Add" onclick="AddTherapeuticClassification()" id="TherapeuticClassification" />
                </div>
            </div>
           <div id="extraTC"></div> 
            <div class="form-group mrgn-bttm-sm">
                <label for="dateofPreparation" class="mrgn-bttm-0">
                    <span class="field-name">Date of Preparation</span> 
                    <span class="datepicker-format"> (<abbr title="Four digits year, dash, two digits month, dash, two digits day">YYYY-MM-DD</abbr>)</span>
                </label> 
                <asp:TextBox id="dateofPreparation" runat="server"  CssClass="form-control input-sm mrgn-tp-0"  ClientIDMode="Static"   type="date" data-rule-dateISO="true" ></asp:TextBox>                                  
            </div>
          <div class="form-group mrgn-bttm-sm">
                <label for="dateofRevision" class="mrgn-bttm-0">
                    <span class="field-name">Date of Revision</span>
                     <span class="datepicker-format"> (<abbr title="Four digits year, dash, two digits month, dash, two digits day">YYYY-MM-DD</abbr>)</span>
                </label> 
                <asp:TextBox id="dateofRevision" runat="server"  CssClass="form-control input-sm mrgn-tp-0"  ClientIDMode="Static"   type="date" data-rule-dateISO="true" ></asp:TextBox>                                  
           </div>
           <div class="form-group mrgn-bttm-sm">
                <label for="submissionControlNumber" class="mrgn-bttm-0"><span class="field-name">Submission Control Number</span></label> 
                <asp:TextBox id="submissionControlNumber" runat="server"  CssClass="form-control input-sm mrgn-tp-0"  ClientIDMode="Static"  type="number" data-rule-digits="true"  min="0" max="999999" ></asp:TextBox>                                  
           </div>
           <div class="form-group mrgn-bttm-sm">
                <label for="footnote" class="mrgn-bttm-0"><span class="field-name">Footnote</span></label> 
                <textarea id="footnote" name="footnote" runat="server" class="textarea mceEditor form-control mrgn-tp-0"  ClientIDMode="Static"></textarea>  
           </div>
<%--           <div class="form-group mrgn-bttm-sm">
                <label for="tableOfContents" class="mrgn-bttm-0"><span class="field-name">Table Of Contents</span></label> 
                <textarea id="tableOfContents" name="tableOfContents" runat="server" class="textarea form-control mrgn-tp-0"  ClientIDMode="Static"></textarea>  
           </div>--%>
        <input type="text" id="brandNameHidden" name="brandNameHidden" class="hidden" value="" />
        <input type="text" id="existXmlFile" name="existXmlFile" class="hidden" value="" />                   
    </div>                          
</div>   
<!--Produect-->
<div class="panel panel-default" id="tabs-2">
    <div class="panel-heading">
        <h2 class="panel-title">Product</h2>
    </div> 
    <div class="panel-body">
        <p> Under construction - coming soon - around Dec 21 </p>
    </div>
</div>                                
<!--Part I: Health Professional Information-->
<div class="panel panel-default" id="tabs-3">
    <div class="panel-heading">
            <h2 class="panel-title">Part I: Health Professional Information</h2>
    </div> 
    <div class="panel-body">
       <!--Summary Product Information-->
       <details class="margin-top-medium">
            <summary id="summaryProductInformationTitle" class="well well-sm">Summary Product Information</summary>
            <div class="form-group"> 
                <label for="summaryProductInformation" class="mrgn-bttm-0"><span class="field-name">Summary Product Information</span></label>
                <textarea id="summaryProductInformation" name="summaryProductInformation" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
       </details>
       <!--Contradictions-->
       <!--Indications And Clinical Use-->
        <details class="margin-top-medium">
            <summary id="indicationsAndClinicalUseTitle" class="well well-sm">Indications And Clinical Use</summary>
            <div class="panel panel-default">
                <div class="panel-heading">
                    <h3 class="panel-title pull-left">Indications And Clinical Use</h3>  
                    <input class="btn btn-default btn-xs pull-right"  type="button" value="Add" id="IndicationsClinical"  onclick="AddIndicationsClinical()" />
                    <div class="clearfix"></div>
                </div>    
                <div class="panel-body">
                    <div class="form-group">                        
                        <textarea id="indicationsClinicalUse" name="indicationsClinicalUse" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
                    </div>
                    <div class="form-group"> 
                        <label for="patientSubsets" class="mrgn-bttm-0"><span class="field-name">Patient Subsets</span></label>
                        <textarea id="patientSubsets" name="patientSubsets" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
                    </div>
                    <div class="form-group"> 
                        <label for="geriatrics" class="mrgn-bttm-0"><span class="field-name input-sm">Geriatrics</span></label>
                        <textarea id="geriatrics" name="geriatrics" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
                    </div>
                    <div class="form-group"> 
                        <label for="pediatrics" class="mrgn-bttm-0"><span class="field-name input-sm">Pediatrics</span></label>
                        <textarea id="pediatrics" name="pediatrics" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
                    </div>
                </div>
            </div>
            <div id="extraIndicationsClinical"></div>
       </details>
       <details class="margin-top-medium">
            <summary id="contradictionsTitle" class="well well-sm">Contradictions</summary>
            <div class="form-group"> 
                <label for="contradictions" class="mrgn-bttm-0">
                    <span class="field-name">Contradictions</span>
                    <span class="label label-info" title="contraindicationsInfo">Info</span>
                </label>
                <textarea id="contradictions" name="contradictions" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
       </details>
      <!--Warnings And Precautions-->   
    <details class="margin-top-medium">
                <summary id="warningsPrecautionsTitle" class="well well-sm">Warnings And Precautions</summary>
                <div class="form-group"> 
                    <label for="warningsAndPrecautions" class="mrgn-bttm-0">
                        <span class="field-name">Warnings And Precautions</span>
                        <span class="label label-info" title="warningsPrecautionInfo">Info</span>
                    </label>
                    <textarea id="warningsAndPrecautions" name="warningsAndPrecautions" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
                </div>
                <div class="form-group">                    
                        <label for="warningsPrecautions0" class="mrgn-bttm-0">
                                <span class="field-name">Headings</span>
                                <span class="label label-info" title="headingsInfo">Info</span>
                                <input class="btn btn-default btn-xs mrgn-lft-sm"  type="button" value="Add" onclick="AddWarningsPrecautions()" id="btnWarningsPrecautions" />
                        </label>                       
                        <div class="row mrgn-lft-sm">
                            <asp:DropDownList ID="warningsPrecautionsList0" CssClass="form-control input-sm col-sm-4" runat="server" ClientIDMode="Static"></asp:DropDownList>
                            <asp:DropDownList ID="specialPopulationsList0" CssClass="form-control input-sm mrgn-lft-sm col-sm-4 hidden" runat="server" ClientIDMode="Static"></asp:DropDownList>
                            <input type="text"  id="specialPopulationsMisc0" name="specialPopulationsMisc"  style="width:70%" class="form-control input-sm mrgn-lft-sm hidden col-sm-8" pattern=".{2,}" data-rule-minlength="2" />
                        </div>
                        <textarea id="warningsPrecautions0" name="warningsPrecautions" class="textarea form-control mrgn-tp-0"></textarea>
               </div>
               <div id="extraWarningsPrecautions"></div>
      </details>
      <!--Adverse Reactions-->      
      <details class="margin-top-medium">
            <summary id="adverseReactionsTitle" class="well well-sm">Adverse Reactions</summary>
            <div class="form-group"> 
                <label for="adverseReaction" class="mrgn-bttm-0"><span class="field-name">Adverse Reactions</span></label>
                <textarea id="adverseReaction" name="adverseReaction" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
            <div class="form-group"> 
                <label for="adverseReactionOverview" class="mrgn-bttm-0"><span class="field-name">Adverse Drug Reaction (ADR) Overview</span></label>
                <textarea id="adverseReactionOverview" name="adverseReactionOverview" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
            <div class="form-group"> 
                <label for="clinicalTrial" class="mrgn-bttm-0"><span class="field-name">Clinical Trial Adverse Drug Reactions</span></label>
                <textarea id="clinicalTrial" name="clinicalTrial" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
            <div class="form-group"> 
                <label for="lessCommonClinicalTrial" class="mrgn-bttm-0"><span class="field-name">Less Common Clinical Trial Adverse Drug Reactions</span></label>
                <textarea id="lessCommonClinicalTrial" name="lessCommonClinicalTrial" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
           <div class="form-group"> 
                <label for="abnormalHematologic" class="mrgn-bttm-0"><span class="field-name">Abnormal Hematologic And Clinical Chemistry Findings</span></label>
                <textarea id="abnormalHematologic" name="abnormalHematologic" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
           <div class="form-group"> 
                <label for="postMarketAdverse" class="mrgn-bttm-0"><span class="field-name">Post-Market Adverse Drug Reactions</span></label>
                <textarea id="postMarketAdverse" name="postMarketAdverse" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>       
       </details>
       <!--Drug Interactions-->      
      <details class="margin-top-medium">
            <summary id="drugInteractionsTitle" class="well well-sm">Drug Interactions</summary>
            <div class="form-group"> 
                <label for="drugInteractions" class="mrgn-bttm-0"><span class="field-name">Drug Interactions</span></label>
                <textarea id="drugInteractions" name="drugInteractions" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
            <div class="form-group"> 
                <label for="drugInteractionsOverview" class="mrgn-bttm-0"><span class="field-name">Drug Interactions Overview</span></label>
                <textarea id="drugInteractionsOverview" name="drugInteractionsOverview" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
            <div class="form-group"> 
                <label for="drugDrugInteractions" class="mrgn-bttm-0"><span class="field-name">Drug-Drug Interactions</span></label>
                <textarea id="drugDrugInteractions" name="drugDrugInteractions" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
            <div class="form-group"> 
                <label for="drugFoodInteractions" class="mrgn-bttm-0"><span class="field-name">Drug-Food Interactions</span></label>
                <textarea id="drugFoodInteractions" name="drugFoodInteractions" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
            <div class="form-group"> 
                <label for="drugHurbInteractions" class="mrgn-bttm-0"><span class="field-name">Drug-Herb Interactions</span></label>
                <textarea id="drugHurbInteractions" name="drugHurbInteractions" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
           <div class="form-group"> 
                <label for="drugLaboratoryInteractions" class="mrgn-bttm-0"><span class="field-name">Drug-Laboratory Test Interactions</span></label>
                <textarea id="drugLaboratoryInteractions" name="drugLaboratoryInteractions" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
           <div class="form-group"> 
                <label for="drugLifestyleInteractions" class="mrgn-bttm-0"><span class="field-name">Drug-Lifestyle Interactions</span></label>
                <textarea id="drugLifestyleInteractions" name="drugLifestyleInteractions" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>              
       </details>
        <!--Dosage And Administration-->      
      <details class="margin-top-medium">
            <summary id="dosageAdministrationTitle" class="well well-sm">Dosage And Administration</summary>
            <div class="form-group"> 
                <label for="dosageAdministration" class="mrgn-bttm-0"><span class="field-name">Dosage And Administration</span></label>
                <textarea id="dosageAdministration" name="dosageAdministration" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
            <div class="form-group"> 
                <label for="dosingConsiderations" class="mrgn-bttm-0"><span class="field-name">Dosing Considerations</span></label>
                <textarea id="dosingConsiderations" name="dosingConsiderations" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
            <div class="form-group"> 
                <label for="recommendedAdjustment" class="mrgn-bttm-0"><span class="field-name">Recommended Dose And Dosage Adjustment</span></label>
                <textarea id="recommendedAdjustment" name="recommendedAdjustment" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
            <div class="form-group"> 
                <label for="dosageAdministrationMissedDose" class="mrgn-bttm-0"><span class="field-name">Missed Dose</span></label>
                <textarea id="dosageAdministrationMissedDose" name="dosageAdministrationMissedDose" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
            <div class="form-group"> 
                <label for="administration" class="mrgn-bttm-0"><span class="field-name">Administration</span></label>
                <textarea id="administration" name="administration" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
           <div class="form-group"> 
                <label for="reconstitution" class="mrgn-bttm-0"><span class="field-name">Reconstitution</span></label>
                <textarea id="reconstitution" name="reconstitution" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
           <div class="form-group"> 
                <label for="oralSolutions" class="mrgn-bttm-0"><span class="field-name">Oral Solutionss</span></label>
                <textarea id="oralSolutions" name="oralSolutions" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
           <div class="form-group"> 
                <label for="parenteralProducts" class="mrgn-bttm-0"><span class="field-name">parenteralProducts</span></label>
                <textarea id="parenteralProducts" name="parenteralProducts" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>                   
       </details>
         <!--Overdosage-->
       <details class="margin-top-medium">
            <summary id="overdosageTitle" class="well well-sm">Overdosage</summary>
            <div class="form-group"> 
                <label for="overdosage" class="mrgn-bttm-0">
                    <span class="field-name">Overdosage</span>
                    <span class="label label-info" title="overdosageInfo">Info</span>
                </label>
                <textarea id="overdosage" name="overdosage" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
       </details>
     <!--Action And Clinical Pharmacology-->   
     <details class="margin-top-medium">
                <summary id="actionClinicalTitle" class="well well-sm">Action And Clinical Pharmacology</summary>
                <div class="form-group"> 
                    <label for="actionClinical" class="mrgn-bttm-0">
                        <span class="field-name">Action And Clinical Pharmacology</span>
                        <span class="label label-info" title="Info">Info</span>
                    </label>
                    <textarea id="actionClinical" name="actionClinical" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
                </div>
                <div class="form-group"> 
                    <label for="mechanismAction" class="mrgn-bttm-0">
                        <span class="field-name">Mechanism Of Action</span>
                        <span class="label label-info" title="Info">Info</span>
                    </label>
                    <textarea id="mechanismAction" name="mechanismAction" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
                </div>
                <div class="form-group"> 
                    <label for="pharmacodynamics" class="mrgn-bttm-0"><span class="field-name">Pharmacodynamics</span></label>
                    <textarea id="pharmacodynamics" name="pharmacodynamics" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
                </div>
                <div class="form-group">                    
                        <label for="pharmacokinetics0" class="mrgn-bttm-0">
                                <span class="field-name">Pharmacokinetics</span>
                                <input class="btn btn-default btn-xs mrgn-lft-sm"  type="button" value="Add" onclick="AddPharmacokinetics()" id="btnPharmacokinetics" />
                        </label>                       
                        <div class="row mrgn-lft-sm">
                            <asp:DropDownList ID="pharmacokineticsList0" CssClass="form-control input-sm col-sm-4" runat="server" ClientIDMode="Static"></asp:DropDownList>
                            <asp:DropDownList ID="specialConditionsList0" CssClass="form-control input-sm col-sm-4 mrgn-lft-sm hidden" runat="server" ClientIDMode="Static"></asp:DropDownList>
                        </div>
                        <textarea id="pharmacokinetics0" name="pharmacokinetics" class="textarea form-control mrgn-tp-0"></textarea>
               </div>
               <div id="extraPharmacokinetics"></div>
      </details>
      <!--Storage and Stability--> 
      <details class="margin-top-medium">
            <summary id="storageandStabilityTitle" class="well well-sm">Storage and Stability</summary>
            <div class="form-group"> 
                <label for="storageandStability" class="mrgn-bttm-0"><span class="field-name">Storage and Stability</span></label>
                <textarea id="storageandStability" name="storageandStability" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
       </details>
      <!--Special Handling Instructions--> 
      <details class="margin-top-medium">
            <summary id="specialHandlingInstructionsTitle" class="well well-sm">Special Handling Instructions</summary>
            <div class="form-group"> 
                <label for="specialHandlingInstructions" class="mrgn-bttm-0"><span class="field-name">Special Handling Instructions</span></label>
                <textarea id="specialHandlingInstructions" name="specialHandlingInstructions" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
       </details>  
      <!--Dosage Forms, Composition and Packaging--> 
      <details class="margin-top-medium">
            <summary id="dosageFormsCompositionTitle" class="well well-sm">Dosage Forms, Composition and Packaging</summary>
            <div class="form-group"> 
                <label for="dosageFormsComposition" class="mrgn-bttm-0"><span class="field-name">Dosage Forms, Composition and Packaging</span></label>
                <textarea id="dosageFormsComposition" name="dosageFormsComposition" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
       </details>       
    </div>
</div>
<!--Part II: Scientific Information-->
<div class="panel panel-default" id="tabs-4">
    <div class="panel-heading">
            <h2 class="panel-title">Part II: Scientific Information</h2>
    </div> 
    <div class="panel-body">
<!--Pharmaceutical Information-->
        <details class="margin-top-medium">
            <summary id="pharmaceuticalInformationTitle" class="well well-sm">Pharmaceutical Information</summary>
             <div class="form-group"> 
                        <label for="pharmaceuticalInformation" class="mrgn-bttm-0"><span class="field-name">Pharmaceutical Information</span></label>
                        <textarea id="pharmaceuticalInformation" name="pharmaceuticalInformation" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
             </div>
            <div class="panel panel-default">
                <div class="panel-heading">
                    <h3 class="panel-title pull-left">Drug Substance</h3>  
                    <input class="btn btn-default btn-xs pull-right"  type="button" value="Add" id="DrugSubstance"  onclick="AddDrugSubstance()" />
                    <div class="clearfix"></div>
                </div>    
                <div class="panel-body">
                    <div class="form-group">                        
                        <textarea id="drugSubstance" name="drugSubstance" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
                    </div>
                    <div class="form-group"> 
                        <label for="drugProperName" class="mrgn-bttm-0"><span class="field-name input-sm">Proper Name</span></label>
                        <input class="form-control input-sm mrgn-tp-0 full-width" id="drugProperName" name="drugProperName" />
                    </div>
                    <div class="form-group"> 
                        <label for="chemicalName" class="mrgn-bttm-0"><span class="field-name input-sm">Chemical Name</span></label>
                        <textarea id="chemicalName" name="chemicalName" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
                    </div>
                    <div class="form-group"> 
                        <label for="molecularFormula" class="mrgn-bttm-0"><span class="field-name input-sm">Molecular Formula And Molecular Mass</span></label>
                        <textarea id="molecularFormula" name="molecularFormula" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
                    </div>
                    <div class="form-group"> 
                        <label for="stereochemistry" class="mrgn-bttm-0"><span class="field-name input-sm">Structural formula, including relative and absolute stereochemistry</span></label>
                        <textarea id="stereochemistry" name="stereochemistry" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
                    </div>
                    <div class="form-group"> 
                        <label for="physicochemical" class="mrgn-bttm-0"><span class="field-name input-sm">Physicochemical Properties</span></label>
                        <textarea id="physicochemical" name="physicochemical" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
                    </div>
                </div>
            </div>
            <div id="extraDrugSubstance"></div>
       </details>




       <!--Clinical Trials-->
        <details class="margin-top-medium">
            <summary id="clinicalTrialsTitle" class="well well-sm">Clinical Trials</summary>
            <div class="form-group"> 
                <label for="clinicalTrials" class="mrgn-bttm-0"><span class="field-name">Clinical Trials</span></label>
                <textarea id="clinicalTrials" name="clinicalTrials" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
            <div class="form-group"> 
                <label for="efficacySafety" class="mrgn-bttm-0"><span class="field-name">Efficacy and Safety Studies  </span></label>
                <textarea id="efficacySafety" name="efficacySafety" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
            <div class="form-group"> 
                <label for="studyDemographics" class="mrgn-bttm-0"><span class="field-name input-sm">Study Demographics And Trial Design</span></label>
                <textarea id="studyDemographics" name="studyDemographics" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
            <div class="form-group"> 
                <label for="studyResults" class="mrgn-bttm-0"><span class="field-name input-sm">Study Results</span></label>
                <textarea id="studyResults" name="studyResults" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
           <div class="form-group"> 
                <label for="pivotalComparative" class="mrgn-bttm-0"><span class="field-name">Pivotal Comparative Bioavailability Studies</span></label>
                <textarea id="pivotalComparative" name="pivotalComparative" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
       </details>
       <!--Detailed Pharmacology-->
       <details class="margin-top-medium">
            <summary id="detailedPharmacologyTitle" class="well well-sm">Detailed Pharmacology</summary>
            <div class="form-group"> 
                <label for="detailedPharmacology" class="mrgn-bttm-0"><span class="field-name">Summary Product Information</span></label>
                <textarea id="detailedPharmacology" name="detailedPharmacology" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
       </details>
       <!--Microbiology-->
       <details class="margin-top-medium">
            <summary id="microbiologyTitle" class="well well-sm">Microbiology</summary>
            <div class="form-group"> 
                <label for="contradictions" class="mrgn-bttm-0"><span class="field-name">Microbiology</span></label>
                <textarea id="microbiology" name="microbiology" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
       </details>
         <!--Toxicology-->
       <details class="margin-top-medium">
            <summary id="toxicologyTitle" class="well well-sm">Toxicology</summary>
            <div class="form-group"> 
                <label for="overdosage" class="mrgn-bttm-0"><span class="field-name">Toxicology</span></label>
                <textarea id="toxicology" name="toxicology" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
       </details>
     <!--References-->      
      <details class="margin-top-medium">
            <summary id="referencesTitle" class="well well-sm">References</summary>
            <div class="form-group"> 
                <label for="storageandStability" class="mrgn-bttm-0"><span class="field-name">References</span></label>
                <textarea id="references" name="references" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
       </details>      
    </div>
</div>
<!--Part III: Consumer Information-->
<div class="panel panel-default" id="tabs-5">
    <div class="panel-heading">
            <h2 class="panel-title">Part III: Consumer Information</h2>
    </div> 
    <div class="panel-body">
       <!--General-->
       <details class="margin-top-medium">
            <summary id="generalTitle" class="well well-sm">General</summary>
            <div class="form-group"> 
                <label for="general" class="mrgn-bttm-0"><span class="field-name">General</span></label>
                <textarea id="general" name="general" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
       </details>
       <!--Opening Disclaimer-->
       <details class="margin-top-medium">
            <summary id="openingDisclaimerTitle" class="well well-sm">Opening Disclaimer</summary>
            <div class="form-group"> 
                <label for="openingDisclaimer" class="mrgn-bttm-0"><span class="field-name">Opening Disclaimer</span></label>
                <textarea id="openingDisclaimer" name="openingDisclaimer" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
       </details>
      <!--About This Medication-->      
      <details class="margin-top-medium">
            <summary id="aboutMedicationTitle" class="well well-sm">About This Medication</summary>
            <div class="form-group"> 
                <label for="aboutMedication" class="mrgn-bttm-0"><span class="field-name">About This Medication</span></label>
                <textarea id="aboutMedication" name="aboutMedication" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
            <div class="form-group"> 
                <label for="medicationUsedFor" class="mrgn-bttm-0"><span class="field-name">What The Medication Is Used For</span></label>
                <textarea id="medicationUsedFor" name="medicationUsedFor" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
            <div class="form-group"> 
                <label for="whatItDoes" class="mrgn-bttm-0"><span class="field-name">What It Does</span></label>
                <textarea id="whatItDoes" name="whatItDoes" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
            <div class="form-group"> 
                <label for="whenNotBeUsed" class="mrgn-bttm-0"><span class="field-name">When It Should Not Be Used</span></label>
                <textarea id="whenNotBeUsed" name="whenNotBeUsed" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
           <div class="form-group"> 
                <label for="medicinalIngredient" class="mrgn-bttm-0"><span class="field-name">What The Medicinal Ingredient Is</span></label>
                <textarea id="medicinalIngredient" name="medicinalIngredient" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
           <div class="form-group"> 
                <label for="nonmedicinalIngredients" class="mrgn-bttm-0"><span class="field-name">What The Important Nonmedicinal Ingredients Are</span></label>
                <textarea id="nonmedicinalIngredients" name="nonmedicinalIngredients" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
            <div class="form-group"> 
                <label for="whatDosageForms" class="mrgn-bttm-0"><span class="field-name">What Dosage Forms It Comes In</span></label>
                <textarea id="whatDosageForms" name="whatDosageForms" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>          
       </details>  
         <!--Warnings and Precautions-->
       <details class="margin-top-medium">
            <summary id="warningAndPrecautionTitle" class="well well-sm">Warnings and Precautions</summary>
            <div class="form-group"> 
                <label for="warningAndPrecaution" class="mrgn-bttm-0"><span class="field-name">Warnings and Precautions</span></label>
                <textarea id="warningAndPrecaution" name="warningAndPrecaution" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
       </details>
     <!--Interactions With This Medication-->      
      <details class="margin-top-medium">
            <summary id="interactionsMedicationTitle" class="well well-sm">Interactions With This Medication</summary>
            <div class="form-group"> 
                <label for="interactionsMedication" class="mrgn-bttm-0"><span class="field-name">Interactions With This Medication</span></label>
                <textarea id="interactionsMedication" name="interactionsMedication" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
       </details>
      <!--Side effects and what to do about them-->      
      <details class="margin-top-medium">
            <summary id="sideEffectsWhatTodoTitle" class="well well-sm">Side effects and what to do about them</summary>
            <div class="form-group"> 
                <label for="sideEffectsWhatTodo" class="mrgn-bttm-0"><span class="field-name">Side effects and what to do about them</span></label>
                <textarea id="sideEffectsWhatTodo" name="sideEffectsWhatTodo" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
       </details>  
      <!--Proper Use Of This Medication-->      
      <details class="margin-top-medium">
            <summary id="properUseMedicationTitle" class="well well-sm">Proper Use Of This Medication</summary>
            <div class="form-group"> 
                <label for="properUseMedication" class="mrgn-bttm-0"><span class="field-name">Proper Use Of This Medication</span></label>
                <textarea id="properUseMedication" name="properUseMedication" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
            <div class="form-group"> 
                <label for="usualDose" class="mrgn-bttm-0"><span class="field-name">Usual Dose</span></label>
                <textarea id="usualDose" name="usualDose" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
           <div class="form-group"> 
                <label for="overdose" class="mrgn-bttm-0"><span class="field-name">Overdose</span></label>
                <textarea id="overdose" name="overdose" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
           <div class="form-group"> 
                <label for="missedDose" class="mrgn-bttm-0"><span class="field-name">Missed Dose</span></label>
                <textarea id="missedDose" name="missedDose" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>        
       </details>  
      <!--How to store it-->      
      <details class="margin-top-medium">
            <summary id="howStoreItTitle" class="well well-sm">How to store it</summary>
            <div class="form-group"> 
                <label for="howStoreIt" class="mrgn-bttm-0"><span class="field-name">How to store it</span></label>
                <textarea id="howStoreIt" name="howStoreIt" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
       </details>   
      <!--More information-->      
      <details class="margin-top-medium">
            <summary id="moreInformationTitle" class="well well-sm">More information</summary>
            <div class="form-group"> 
                <label for="moreInformation" class="mrgn-bttm-0"><span class="field-name">More information</span></label>
                <textarea id="moreInformation" name="moreInformation" class="textarea form-control mrgn-tp-0" runat="server" ></textarea>
            </div>
       </details>
      <div class="form-group mrgn-bttm-sm">
                <label for="lastRevision" class="mrgn-bttm-0">
                    <span class="field-name">Part 3 Revision Date</span>
                     <span class="datepicker-format"> (<abbr title="Four digits year, dash, two digits month, dash, two digits day">YYYY-MM-DD</abbr>)</span>
                </label> 
                <asp:TextBox id="lastRevision" runat="server"  CssClass="form-control input-sm mrgn-tp-0"  ClientIDMode="Static"   type="date" data-rule-dateISO="true" ></asp:TextBox>                                  
      </div>
    </div>
</div>
 <!--Load XML text--> 
<section class="panel panel-default" id="tabs-6">	
            <header class="panel-heading">
                <h2 class="panel-title"></h2>
                <div class="row">
                    <h2 class="col-sm-2 mrgn-tp-sm">XML View</h2>
                    <div class="mrgn-tp-sm">
                        <asp:Button ID="btnViewXML" runat="server" CssClass="btn btn-default"  Text="Update" OnClick="btnViewXML_Click"  />  
                    </div>
                </div>
            </header>
            <div class="panel-body">
<%--                <asp:TextBox ID="savedXml" runat="server" TextMode="MultiLine" Rows="50" Columns="100" CssClass="full-width mrgn-lft-sm mrgn-rght-sm mceNoEditor" ClientIDMode="Static"></asp:TextBox>--%>
                <div id="xmlOutput" runat="server">Please click update button in order to see xml</div>
            </div>
    </section>
            </form> 
            </div>
           </div>
    </main>
</div>

    <aside class="gc-nttvs container">
        <h2>Government of Canada activities and initiatives</h2>
        <div id="gcwb_prts" class="wb-eqht row" data-ajax-replace="//cdn.canada.ca/gcweb-cdn-live/features/features-en.html"><p class="mrgn-lft-md"><a href="http://www.canada.ca/activities.html">Access Government of Canada activities and initiatives</a></p> </div>
    </aside>
    <footer role="contentinfo" id="wb-info">
        <nav role="navigation" class="container visible-sm visible-md visible-lg wb-navcurr">
            <h2 class="wb-inv">About this site</h2>
            <div class="row">
                <div class="col-sm-3 col-lg-3">
                    <section>
                        <h3>Contact information</h3>
                        <!--Start Healthy Canadians contact info-->
                        <ul class="list-unstyled">
                            <li><a href="/report-signalez/index-eng.php">Report a concern</a></li>
                            <li><a href="/say-exprimez/index-eng.php">Public involvement</a></li>
                            <li><a href="/contact-contactez/index-eng.php">General enquiries</a></li>
                            <li><a href="/connect-connectez/index-eng.php">Stay connected</a></li>
                        </ul>
                        <!--End Healthy Canadians contact info-->
                    </section>
                    <section>
                        <h3>News</h3>
                        <ul class="list-unstyled">
                            <li><a href="http://news.gc.ca/web/index-en.do">Newsroom</a></li>
                            <li><a href="http://news.gc.ca/web/nwsprdct-en.do?mthd=tp&amp;crtr.tp1D=1">News releases</a></li>
                            <li><a href="http://news.gc.ca/web/nwsprdct-en.do?mthd=tp&amp;crtr.tp1D=3">Media advisories</a></li>
                            <li><a href="http://news.gc.ca/web/nwsprdct-en.do?mthd=tp&amp;crtr.tp1D=970">Speeches</a></li>
                            <li><a href="http://news.gc.ca/web/nwsprdct-en.do?mthd=tp&amp;crtr.tp1D=980">Statements</a></li>
                        </ul>
                    </section>
                </div>
                <section class="col-sm-3 col-lg-3">
                    <h3>Government</h3>
                    <ul class="list-unstyled">
                        <li><a href="http://www.canada.ca/en/gov/system">How government works</a></li>
                        <li><a href="http://www.canada.ca/en/gov/dept">Departments and agencies</a></li>
                        <li><a href="http://pm.gc.ca/eng">Prime Minister</a></li>
                        <li><a href="http://www.canada.ca/en/gov/ministers">Ministers</a></li>
                        <li><a href="http://www.canada.ca/en/gov/publicservice">Public service and military</a></li>
                        <li><a href="http://www.canada.ca/en/government/system/laws.html">Treaties, laws and regulations</a></li>
                        <li><a href="http://www.canada.ca/en/gov/libraries">Libraries</a></li>
                        <li><a href="http://www.canada.ca/en/gov/publications">Publications</a></li>
                        <li><a href="http://www.canada.ca/en/gov/statistics">Statistics and data</a></li>
                        <li><a href="http://www.canada.ca/en/newsite.html">About Canada.ca</a></li>
                    </ul>
                </section>
                <section class="col-sm-3 col-lg-3 brdr-lft">
                    <h3>Transparency</h3>
                    <ul class="list-unstyled">
                        <li><a href="http://www.canada.ca/en/transparency/reporting.html">Government-wide reporting</a></li>
                        <li><a href="http://open.canada.ca/en">Open government</a></li>
                        <li><a href="http://www.canada.ca/en/transparency/disclosure.html">Proactive disclosure</a></li>
                        <li><a href="http://www.canada.ca/en/transparency/terms.html">Terms and conditions</a></li>
                        <li><a href="http://www.canada.ca/en/transparency/privacy.html">Privacy</a></li>
                    </ul>
                </section>
                <div class="col-sm-3 col-lg-3 brdr-lft">
                    <section>
                        <h3>Feedback</h3>
                        <p><a href="http://www.canada.ca/en/contact/feedback.html"><img src="/distro/4.0.20/GCWeb/assets/feedback.png" alt="Feedback about this Web site"></a></p>
                    </section>
                    <section>
                        <h3>Social media</h3>
                        <p><a href="http://www.canada.ca/en/social"><img src="/distro/4.0.20/GCWeb/assets/social.png" alt="Social media"></a></p>
                    </section>
                    <section>
                        <h3>Mobile centre</h3>
                        <p><a href="http://www.canada.ca/en/mobile"><img src="/distro/4.0.20/GCWeb/assets/mobile.png" alt="Mobile centre"></a></p>
                    </section>
                </div>
            </div>
        </nav>
        <div class="brand">
            <div class="container">
                <div class="row">
                    <div class="col-xs-6 visible-sm visible-xs tofpg">
                        <a href="#wb-cont">Top of Page <span class="glyphicon glyphicon-chevron-up"></span></a>
                    </div>
                    <div class="col-xs-6 col-md-12 text-right">
                        <object type="image/svg+xml" tabindex="-1" role="img" data="/distro/4.0.20/GCWeb/assets/wmms-blk.svg" aria-label="Symbol of the Government of Canada"></object>
                    </div>
                </div>
            </div>
        </div>
    </footer>
    
    <!--[if gte IE 9 | !IE ]><!-->
    <script src="/distro/4.0.20/wet-boew/js/wet-boew.min.js"></script>
    <!--<![endif]-->
    <!--[if lt IE 9]>
    <script src="/distro/4.0.20/wet-boew/js/ie8-wet-boew2.min.js"></script>
    <![endif]-->   
    <script>
        function LoadSavedXMLString(value)
        {
            alert("success");
            $("textarea#saveTextXml").html(value);
          }

          function validatePage() {
              var check = true;
              // Check only simple textbox for now
              //if ($("#txtImportant").val() == '') check = false;

              //if (!check) {
              //    alert('Missing data. Please complete');
              //    return false;
              //}
              //else {
                  $("#btnSaveDraft").val('Processing...');
                  $("#btnSaveDraft").attr("disabled", true);
                  return true;
              //}
          }
    </script>
    </body>    
</html>
