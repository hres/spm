$(document).ready(function () {    
    $("#warningsPrecautionsList0").attr("name", "warningsPrecautionsList");
    $("#specialPopulationsList0").attr("name", "specialPopulationsList");
    $("#pharmacokineticsList0").attr("name", "pharmacokineticsList");
    $("#specialConditionsList0").attr("name", "specialConditionsList");
    changeWarningsAndPrecautionsCV(0);
    changePharmacokineticsCV(0);
    //$('#pharmacokineticsList0').change(function () { changePharmacokineticsCV(0); });
    setup();
  
});


var agentAddressCounter = 0;
function AddAgenetAddress() {
    //alert("im here");
    agentAddressCounter = agentAddressCounter + 1;
    var div = document.createElement('div');
    var identity = document.createAttribute("id");
    identity.value = "AgentAddress" + agentAddressCounter;
    div.setAttributeNode(identity);
    var agentComName = "agentComName" + agentAddressCounter.toString();
    var agentComID = "agentComID" + agentAddressCounter.toString();
    var agentOrganizationRole = "agentOrganizationRole" + agentAddressCounter.toString();
    var agentStreet = "agentStreet" +  agentAddressCounter.toString();
    var agentCity = "agentCity" +  agentAddressCounter.toString();
    var agentProvince = "agentProvince" +  agentAddressCounter.toString();
    var agentCountry = "agentCountry" +  agentAddressCounter.toString();
    var agentPostalCode = "agentPostalCode" +  agentAddressCounter.toString();
    var agentPhone = "agentPhone" +  agentAddressCounter.toString();
    var agentEmail = "agentEmail" +  agentAddressCounter.toString();
    var agentFirstName = "agentFirstName" +  agentAddressCounter.toString();
    var agentLastName = "agentLastName" +  agentAddressCounter.toString();

    var returnString = "<hr class='mrgn-bttm-0'>" +
"<div class='form-group row mrgn-bttm-0'>" +
    "<div class='col-sm-10'>"+
     "<label for='" + agentComName + "' class='mrgn-bttm-0'><span class='field-name'>Company name</span> </label>" +
        "<input class='form-control input-sm' id='" + agentComName + "' name='agentComName' pattern='.{2,}' data-rule-minlength='2' />" +
    "</div>" +
        "<div class='col-sm-2 text-right'>" + 
        '<input class="btn btn-default btn-xs" type="button" value="Remove" onclick="RemoveAgentAddress(' + agentAddressCounter + ')" id="btnRemoveAgentAddress(' + agentAddressCounter + ')" />' +
    "</div>"+
"</div>" +
"<div class='form-group mrgn-bttm-0'>" +
    "<label for='" + agentComID + "' class='mrgn-bttm-0'><span class='field-name'>Company ID(1.33)</span> </label>" +
     "<input class='form-control input-sm' id='" + agentComID + "' name='agentComID' pattern='.{2,}' data-rule-minlength='2' />" +
"</div>"+
"<div class='form-group mrgn-bttm-0'>" +
	"<label for='" + agentOrganizationRole + "' class='mrgn-bttm-0'><span class='field-name'>Organization role(1.35)</span> </label>" +
          "<select id='" + agentOrganizationRole + "' name='agentOrganizationRole' class='form-control input-sm'>" +
             "<option label='Select an organization role'></option>" +
             "<option value='???'>No value yet</option>" +
           "</select>" +
"</div>"+
"<div class='form-group mrgn-bttm-0'>" +
    "<label for='" + agentStreet + "' class='mrgn-bttm-0'><span class='field-name'>Street</span></label>"+
    "<input class='form-control input-sm full-width' id='" + agentStreet + "' name='agentStreet' pattern='.{2,}' data-rule-minlength='2' />" +
"</div>" + 
"<div class='form-group mrgn-bttm-0'>" +
    "<label for='" + agentCity + "' class='mrgn-bttm-0'><span class='field-name'>City</span></label>" +
    "<input class='form-control input-sm' id='" + agentCity + "' name='agentCity' pattern='.{2,}' data-rule-minlength='2' />" +
"</div>" +            
"<div class='form-group mrgn-bttm-0'>" +
    "<label for='" + agentProvince + "' class='mrgn-bttm-0'><span class='field-name'>Province</span> </label>" +
    "<input class='form-control input-sm' id='" + agentProvince + "' name='agentProvince' pattern='.{2,}' data-rule-minlength='2' />" +
"</div>" + 
"<div class='form-group mrgn-bttm-0'>" +
    "<label for='" + agentCountry + "' class='mrgn-bttm-0'><span class='field-name'>Country</span> </label>" +
    "<input class='form-control input-sm' id='" + agentCountry + "' name='agentCountry' pattern='.{2,}' data-rule-minlength='2' />" +
"</div>" + 
"<div class='form-group mrgn-bttm-0'>" +
    "<label for='" + agentPostalCode + "' class='mrgn-bttm-0'><span class='field-name'>Postal code</span></label>" +
    "<input class='form-control input-sm' id='" + agentPostalCode + "' name='agentPostalCode' size='7' maxlength='7'  data-rule-postalCodeCA='true' />" +
"</div>" +              
"<div class='form-group mrgn-bttm-0'>" +
    "<label for='" + agentPhone + "' class='mrgn-bttm-0'><span class='field-name'>Telephone number</span> </label>" +
    "<input class='form-control input-sm' id='" + agentPhone + "' name='agentPhone' data-rule-phoneUS='true' type='tel' />" +
"</div>" + 
"<div class='form-group mrgn-bttm-0'>" +
    "<label for='" + agentEmail + "' class='mrgn-bttm-0'><span class='field-name'>Email address</span> </label>" +
    "<input class='form-control input-sm' id='" + agentEmail + "' name='agentEmail'  type='email' />" +
"</div>" + 
"<div class='form-group mrgn-bttm-0'>" +
    "<label for='" + agentFirstName + "' class='mrgn-bttm-0'><span class='field-name'>First name</span></label>" +
    "<input class='form-control input-sm' id='" + agentFirstName + "' name='agentFirstName' pattern='.{2,}' data-rule-minlength='2' />" +
"</div>" + 
"<div class='form-group mrgn-bttm-0'>" +
    "<label for='" + agentLastName + "' class='mrgn-bttm-0'><span class='field-name'>Last name</span></label>" +
    "<input class='form-control input-sm' id='" + agentLastName + "' name='agentLastName' pattern='.{2,}' data-rule-minlength='2' />" +
"</div>"  ;
    div.innerHTML = returnString;
    document.getElementById("divExtrAgentAddress").appendChild(div);
}
function RemoveAgentAddress(i) {
    var rowid = "#AgentAddress" + i;
    $(rowid).remove();
}

var psCounter = 0;
function AddPharmaceuticalStandard()
{
    psCounter = psCounter + 1;
    var div = document.createElement('div');
    var identity = document.createAttribute("id");
    identity.value = "PharmaceuticalStandard" + psCounter;
    div.setAttributeNode(identity);
    var pharmaceuticalStandard = "pharmaceuticalStandard" + psCounter.toString();
    var returnString = "<div class='row mrgn-lft-sm'>" +
                             "<select id='" + pharmaceuticalStandard + "' name='pharmaceuticalStandard' class='form-control input-sm col-sm-3'>" +
                                "<option label='Select a Pharmaceutical Standard'></option>" +
                             "</select>" +        
                             '<input class="btn btn-default btn-xs mrgn-lft-sm" type="button" value="Remove" onclick="RemovePharmaceuticalStandard(' + psCounter + ')" id="btnRemovePharmaceuticalStandard(' + psCounter + ')" />' +
                        "</div>";

    AddPharmaceuticalStandardCV(psCounter);

    div.innerHTML = returnString;
    document.getElementById("extraPS").appendChild(div);
}
function RemovePharmaceuticalStandard(i) {
    var rowid = "#PharmaceuticalStandard" + i;
    $(rowid).remove();
}


function AddPharmaceuticalStandardCV(i) {
    $.get('/spmAssets/xml/hcSPLcv.xml', function (xmlCVlist) {
        $(xmlCVlist).find('items').each(function () {
            var id, name, code;
            id = $(this).attr('id'); // or just `this.id`
            if (id == "110") {
                $(this).children('item').each(function () {
                    code = $(this).attr('code');
                    name = $(this).attr('name');
                    $('<option value="' + code + '">' + name + '</option>').appendTo('#pharmaceuticalStandard' + i.toString());
                });
            }
        });
    });
}

var tcCounter = 0;
function AddTherapeuticClassification() {
    tcCounter = tcCounter + 1;
    var div = document.createElement('div');
    var identity = document.createAttribute("id");
    identity.value = "TherapeuticClassification" + tcCounter;
    div.setAttributeNode(identity);
    var therapeuticClassification = "therapeuticClassification" + tcCounter.toString();
    var returnString = "<div class='row mrgn-lft-sm'>" +
                             "<select id='" + therapeuticClassification + "' name='therapeuticClassification' class='form-control input-sm col-sm-3'>" +
                                "<option label='Select a Therapeutic Classification'></option>" +
                             "</select>" +
                             '<input class="btn btn-default btn-xs mrgn-lft-sm" type="button" value="Remove" onclick="RemoveTherapeuticClassification(' + tcCounter + ')" id="btnRemoveTherapeuticClassification(' + psCounter + ')" />' +
                        "</div>";

    AddTherapeuticClassificationCV(tcCounter);

    div.innerHTML = returnString;
    document.getElementById("extraTC").appendChild(div);
}
function RemoveTherapeuticClassification(i) {
    var rowid = "#TherapeuticClassification" + i;
    $(rowid).remove();
}


function AddTherapeuticClassificationCV(i) {
    $.get('/spmAssets/xml/hcSPLcv.xml', function (xmlCVlist) {
        $(xmlCVlist).find('items').each(function () {
            var id, name, code;
            id = $(this).attr('id'); // or just `this.id`
            if (id == "120") {
                $(this).children('item').each(function () {
                    code = $(this).attr('code');
                    name = $(this).attr('name');
                    $('<option value="' + code + '">' + name + '</option>').appendTo('#therapeuticClassification' + i.toString());
                });
            }
        });
    });
}

function AddWarningsAndPrecautionsCV(i) {
    $.get('/spmAssets/xml/hcSPLcv.xml', function (xmlCVlist) {
        $(xmlCVlist).find('items').each(function () {
            var id, name, code;
            id = $(this).attr('id'); // or just `this.id`
            if (id == "210") {
                $(this).children('item').each(function () {
                    code = $(this).attr('code');
                    name = $(this).attr('name');
                    $('<option value="' + code + '">' + name + '</option>').appendTo('#warningsPrecautionsList' + i.toString());
                });
            }
        });
    });
}

function AddSpecialPopulationsCV(i) {
    $.get('/spmAssets/xml/hcSPLcv.xml', function (xmlCVlist) {
        $(xmlCVlist).find('items').each(function () {
            var id, name, code;
            id = $(this).attr('id'); // or just `this.id`
            if (id == "210-210") {
                $(this).children('item').each(function () {
                    code = $(this).attr('code');
                    name = $(this).attr('name');
                    $('<option value="' + code + '">' + name + '</option>').appendTo('#specialPopulationsList' + i.toString());
                });
            }
        });
    });
}

function changeWarningsAndPrecautionsCV(i) {
    $('#warningsPrecautionsList' + i.toString()).change(function () {
        var selected = $(this).val();
        $('#specialPopulationsMisc' + i.toString()).addClass("hidden");
        $('#specialPopulationsList' + i.toString()).addClass("hidden");
        if (selected == '210-220') {
            $('#specialPopulationsMisc' + i.toString()).removeClass("hidden");
            $('#specialPopulationsList' + i.toString()).addClass("hidden");
        } else if (selected == '210-210') {
            $('#specialPopulationsList' + i.toString()).removeClass("hidden");
            $('#specialPopulationsMisc' + i.toString()).addClass("hidden");
        } else {
            $('#specialPopulationsMisc' + i.toString()).addClass("hidden");
            $('#specialPopulationsList' + i.toString()).addClass("hidden");
        }
    });
}

var indicationsClinicalCounter = 0;
function AddIndicationsClinical() {
    indicationsClinicalCounter = indicationsClinicalCounter + 1;
    var div = document.createElement('div');
    var identity = document.createAttribute("id");
    identity.value = "IndicationsClinical" + indicationsClinicalCounter;
    div.setAttributeNode(identity);
    var att = document.createAttribute("class");
    att.value = "panel panel-default";
    div.setAttributeNode(att);
    var indicationsClinicalUse = "indicationsClinicalUse" + indicationsClinicalCounter.toString();
    var patientSubsets = "patientSubsets" + indicationsClinicalCounter.toString();
    var geriatrics = "geriatrics" + indicationsClinicalCounter.toString();
    var pediatrics = "pediatrics" + indicationsClinicalCounter.toString();
    var returnString = "<div class='panel-heading'>" +
                    "<h3 class='panel-title pull-left'>Indications And Clinical Use</h3>" +
					'<input class="btn btn-default btn-xs pull-right" type="button" value="Remove" onclick="RemoveIndicationsClinical(' + indicationsClinicalCounter + ')" id="btnRemoveIndicationsClinical(' + indicationsClinicalCounter + ')" />' +
                    "<div class='clearfix'></div> " +
                "</div>" +
                "<div class='panel-body'>" +
                    "<div class='form-group'>" +
                        "<textarea id=id='" + indicationsClinicalUse + "' name='indicationsClinicalUse' class='textarea form-control mrgn-tp-0' runat='server' ></textarea>" +
                    "</div>" +
					"<div class='form-group'>" +
                        "<label for='" + patientSubsets + "' class='mrgn-bttm-0'><span class='field-name input-sm'>Patient Subsets</span> </label>" +
                        "<textarea id=id='" + patientSubsets + "' name='patientSubsets' class='textarea form-control mrgn-tp-0'></textarea>" +
                    "</div>" +
					"<div class='form-group'>" +
                        "<label for='" + geriatrics + "' class='mrgn-bttm-0'><span class='field-name input-sm'>Geriatrics</span> </label>" +
                        "<textarea id=id='" + geriatrics + "' name='geriatrics' class='textarea form-control mrgn-tp-0'></textarea>" +
                   "</div>" +
                    "<div class='form-group'>" +
                        "<label for='" + pediatrics + "' class='mrgn-bttm-0'><span class='field-name input-sm'>Pediatrics</span> </label>" +
                        "<textarea id=id='" + pediatrics + "' name='pediatrics' class='textarea form-control mrgn-tp-0'></textarea>" +
                    "</div>" +
                "</div>";
    div.innerHTML = returnString;
    document.getElementById("extraIndicationsClinical").appendChild(div);
    setup();
}


var drugSubstanceCounter = 0;
function AddDrugSubstance() {
    drugSubstanceCounter = drugSubstanceCounter + 1;
    var div = document.createElement('div');
    var identity = document.createAttribute("id");
    identity.value = "DrugSubstance" + drugSubstanceCounter;
    div.setAttributeNode(identity);
    var att = document.createAttribute("class");
    att.value = "panel panel-default";
    div.setAttributeNode(att);
    var drugSubstance = "drugSubstance" + drugSubstanceCounter.toString();
    var drugProperName = "drugProperName" + drugSubstanceCounter.toString();
    var chemicalName = "chemicalName" + drugSubstanceCounter.toString();
    var molecularFormula = "molecularFormula" + drugSubstanceCounter.toString();
    var stereochemistry = "stereochemistry" + drugSubstanceCounter.toString();
    var physicochemical = "physicochemical" + drugSubstanceCounter.toString();

    var returnString = "<div class='panel-heading'>" +
                    "<h3 class='panel-title pull-left'>Drug Substance</h3>" +
					'<input class="btn btn-default btn-xs pull-right" type="button" value="Remove" onclick="RemoveDrugSubstance(' + drugSubstanceCounter + ')" id="btnRemoveDrugSubstance(' + drugSubstanceCounter + ')" />' +
                    "<div class='clearfix'></div> " +
                "</div>" +
                "<div class='panel-body'>" +
                    "<div class='form-group'>" +
                        "<textarea id=id='" + drugSubstance + "' name='drugSubstance' class='textarea form-control mrgn-tp-0' runat='server' ></textarea>" +
                    "</div>" +
                    "<div class='form-group'>" +
                        "<label for='" + drugProperName + "' class='mrgn-bttm-0'><span class='field-name input-sm'>Proper Name</span> </label>" +
                        "<input id=id='" + drugProperName + "' name='drugProperName' class='form-control input-sm mrgn-tp-0 full-width'/>" +
                    "</div>" +
					"<div class='form-group'>" +
                        "<label for='" + chemicalName + "' class='mrgn-bttm-0'><span class='field-name input-sm'>Chemical Name</span> </label>" +
                        "<textarea id=id='" + chemicalName + "' name='chemicalName' class='textarea form-control mrgn-tp-0'></textarea>" +
                    "</div>" +
					"<div class='form-group'>" +
                        "<label for='" + molecularFormula + "' class='mrgn-bttm-0'><span class='field-name input-sm'>Molecular Formula And Molecular Mass</span> </label>" +
                        "<textarea id=id='" + molecularFormula + "' name='molecularFormula' class='textarea form-control mrgn-tp-0'></textarea>" +
                   "</div>" +
                    "<div class='form-group'>" +
                        "<label for='" + stereochemistry + "' class='mrgn-bttm-0'><span class='field-name input-sm'>Structural formula, including relative and absolute stereochemistry</span> </label>" +
                        "<textarea id=id='" + stereochemistry + "' name='stereochemistry' class='textarea form-control mrgn-tp-0'></textarea>" +
                    "</div>" +
                    "<div class='form-group'>" +
                        "<label for='" + physicochemical + "' class='mrgn-bttm-0'><span class='field-name input-sm'>Physicochemical Properties</span></label>" +
                        "<textarea id=id='" + physicochemical + "' name='physicochemical' class='textarea form-control mrgn-tp-0'></textarea>" +
                    "</div>" +
                "</div>";
    div.innerHTML = returnString;
    document.getElementById("extraDrugSubstance").appendChild(div);
    setup();
}


function RemoveDrugSubstance(i) {
    var rowid = "#DrugSubstance" + i;
    $(rowid).remove();
}
var warningsPrecautionsCounter = 0;
function AddWarningsPrecautions() {
    warningsPrecautionsCounter = warningsPrecautionsCounter + 1;
    var div = document.createElement('div');
    var identity = document.createAttribute("id");
    identity.value = "WarningsPrecautions" + warningsPrecautionsCounter;
    div.setAttributeNode(identity);
    //var att = document.createAttribute("class");
    //att.value = "panel panel-default";
    //div.setAttributeNode(att);
    var warningsPrecautionsList = "warningsPrecautionsList" + warningsPrecautionsCounter.toString();
    var specialPopulationsList = "specialPopulationsList" + warningsPrecautionsCounter.toString();
    var specialPopulationsMisc = "specialPopulationsMisc" + warningsPrecautionsCounter.toString();
    var warningsPrecautions = "warningsPrecautions" + warningsPrecautionsCounter.toString();
    var returnString =  "<div class='form-group'>" +                   
                        "<label for='" + warningsPrecautionsList + "' class='mrgn-bttm-0'>" +    
                                "<span class='field-name'>Headings</span>" +    
                                "<span class='label label-info' title='headingsInfo'>Info</span>" +    
                                '<input class="btn btn-default btn-xs mrgn-lft-sm" type="button" value="Remove" onclick="RemoveWarningsPrecautions(' + warningsPrecautionsCounter + ')" id="btnRemoveWarningsPrecautions(' + warningsPrecautionsCounter + ')" />' +
                        "</label>" +                        
                        "<div class='row mrgn-lft-sm'>" + 
                             "<select id='" + warningsPrecautionsList + "' name='warningsPrecautionsList' class='form-control input-sm col-sm-4'>" +
                                "<option label='Select a Warnings And Precautions'></option>" +
                             "</select>" +                            
                            "<select id='" + specialPopulationsList + "' name='specialPopulationsList' class='form-control input-sm mrgn-lft-sm col-sm-4 hidden'>" +
                                "<option label='Select a Special Populations'></option>" +
                             "</select>" +
                            '<input type="text" id="'+ specialPopulationsMisc + '"  name="specialPopulationsMisc"  style="width:70%" class="form-control input-sm mrgn-lft-sm hidden col-sm-8"  pattern=".{2,}" data-rule-minlength="2" />' +
                        "</div>" +
                        "<textarea id=id='" + warningsPrecautions + "' name='warningsPrecautions' class='textarea form-control mrgn-tp-0'></textarea>" +
                "</div>";
    AddWarningsAndPrecautionsCV(warningsPrecautionsCounter);
    AddSpecialPopulationsCV(warningsPrecautionsCounter);
    div.innerHTML = returnString;
    document.getElementById("extraWarningsPrecautions").appendChild(div);
    setup();
    changeWarningsAndPrecautionsCV(warningsPrecautionsCounter);
}
function RemoveWarningsPrecautions(i) {
    var rowid = "#WarningsPrecautions" + i;
    $(rowid).remove();
}

var pharmacokineticsCounter = 0;
function AddPharmacokinetics() {
    pharmacokineticsCounter = pharmacokineticsCounter + 1;
    var div = document.createElement('div');
    var identity = document.createAttribute("id");
    identity.value = "Pharmacokinetics" + pharmacokineticsCounter;
    div.setAttributeNode(identity);
    var pharmacokinetics = "pharmacokinetics" + pharmacokineticsCounter.toString();
    var pharmacokineticsList = "pharmacokineticsList" + pharmacokineticsCounter.toString();
    var specialConditionsList = "specialConditionsList" + pharmacokineticsCounter.toString();

    var returnString = "<div class='form-group'>" +
                        "<label for='" + pharmacokinetics + "' class='mrgn-bttm-0'>" +
                                "<span class='field-name'>Pharmacokinetics</span>" +
                                '<input class="btn btn-default btn-xs mrgn-lft-sm" type="button" value="Remove" onclick="RemovePharmacokinetics(' + pharmacokineticsCounter + ')" id="btnRemovePharmacokinetics(' + pharmacokineticsCounter + ')" />' +
                        "</label>" +
                        "<div class='row mrgn-lft-sm'>" +
                             "<select id='" + pharmacokineticsList + "' name='pharmacokineticsList' class='form-control input-sm col-sm-4'>" +
                                "<option label='Select a Pharmacokinetics'></option>" +
                             "</select>" +
                            "<select id='" + specialConditionsList + "' name='specialConditionsList' class='form-control input-sm mrgn-lft-sm col-sm-4 hidden'>" +
                                "<option label='Select a Special Populations And Conditions'></option>" +
                             "</select>" +
                        "</div>" +
                        "<textarea id=id='" + pharmacokinetics + "' name='pharmacokinetics' class='textarea form-control mrgn-tp-0'></textarea>" +
                "</div>";
    AddPharmacokineticsCV(pharmacokineticsCounter);
    AddSpecialPopulationsConditionsCV(pharmacokineticsCounter);
    div.innerHTML = returnString;
    document.getElementById("extraPharmacokinetics").appendChild(div);
    setup();
    changePharmacokineticsCV(pharmacokineticsCounter);
}
function RemovePharmacokinetics(i) {
    var rowid = "#Pharmacokinetics" + i;
    $(rowid).remove();
}

function AddPharmacokineticsCV(i) {
    $.get('/spmAssets/xml/hcSPLcv.xml', function (xmlCVlist) {
        $(xmlCVlist).find('items').each(function () {
            var id, name, code;
            id = $(this).attr('id'); // or just `this.id`
            if (id == "260-30") {
                $(this).children('item').each(function () {
                    code = $(this).attr('code');
                    name = $(this).attr('name');
                    $('<option value="' + code + '">' + name + '</option>').appendTo('#pharmacokineticsList' + i.toString());
                });
            }
        });
    });
}

function AddSpecialPopulationsConditionsCV(i) {
    $.get('/spmAssets/xml/hcSPLcv.xml', function (xmlCVlist) {
        $(xmlCVlist).find('items').each(function () {
            var id, name, code;
            id = $(this).attr('id'); // or just `this.id`
            if (id == "260-30-50") {
                $(this).children('item').each(function () {
                    code = $(this).attr('code');
                    name = $(this).attr('name');
                    $('<option value="' + code + '">' + name + '</option>').appendTo('#specialConditionsList' + i.toString());
                });
            }
        });
    });
}

function changePharmacokineticsCV(i) {
    $('#pharmacokineticsList' + i.toString()).change(function () {
        alert("im here");
        var selected = $(this).val();
        alert(selected);
        $('#specialConditionsList' + i.toString()).addClass("hidden");
        if (selected == '260-30-50') {
            alert("im here2");
            $('#specialConditionsList' + i.toString()).removeClass("hidden");
        } else {
            $('#specialConditionsList' + i.toString()).addClass("hidden");
        }
    });
}
