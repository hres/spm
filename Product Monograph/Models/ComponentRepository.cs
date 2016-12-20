
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using StructuredProductMonograph.Helpers;

namespace StructuredProductMonograph.Models
{
    public class ComponentRepository : IComponentRepository
    {
        private const string structuredBody = "structuredBody";
        private const string component = "component";
        private const string section = "section";
        private const string ID = "ID";
        private const string id = "id";
        private const string root = "root";
        private const string code = "code";
        private const string codeSystem = "codeSystem";
        private const string displayName = "displayName";
        private const string title = "title";
        private const string text = "text";
        private const string effectiveTime = "effectiveTime";
        private const string subject = "subject";
        private const string manufacturedProduct = "manufacturedProduct";
        private const string name = "name";
        private const string formCode = "formCode";
        private const string asEntityWithGeneric = "asEntityWithGeneric";
        private const string genericMedicine = "genericMedicine";
        private const string asEquivalentEntity = "asEquivalentEntity";
        private const string classCode = "classCode";
        private const string definingMaterialKind = "definingMaterialKind";
        private const string ingredient = "ingredient";
        private const string quantity = "quantity";
        private const string numerator = "numerator";
        private const string value = "value";
        private const string unit = "unit";
        private const string denominator = "denominator";
        private const string ingredientSubstance = "ingredientSubstance";
        private const string activeMoiety = "activeMoiety";
        private const string asContent = "asContent";
        private const string containerPackagedProduct = "containerPackagedProduct";
        private const string author = "author";
        private const string assignedEntity = "assignedEntity";
        private const string representedOrganization = "representedOrganization";
        private const string extension = "extension";
        private const string contactParty = "contactParty";
        private const string addr = "addr";
        private const string streetAddressLine = "streetAddressLine";
        private const string city = "city";
        private const string state = "state";
        private const string postalCode = "postalCode";
        private const string country = "country";
        private const string telecom = "telecom";
        private const string contactPerson = "contactPerson";
        private const string assignedOrganization = "assignedOrganization";
        private const string performance = "performance";
        private const string actDefinition = "actDefinition";

        private XNamespace xmlns = XNamespace.Get("urn:hl7-org:v3");

        public void CreateComponent(Section item)
        {
            XElement componentTag = null;
            var document = SessionHelper.current.saveForm;
            var structured = document.Root.Descendants(xmlns + component).Descendants(structuredBody).FirstOrDefault();
            if (structured == null)
            {
                structured = document.Root.Descendants(xmlns + component).Descendants(xmlns + structuredBody).FirstOrDefault();
            }

            if (item != null)
            {
                if( string.IsNullOrWhiteSpace(item.rootID))
                {
                    item.rootID = SessionHelper.current.xmlFileGuid;
                }
                componentTag = new XElement(component,
                                   new XElement(section, new XAttribute(ID, item.sectionID),
                                       new XElement(id, new XAttribute(root, item.rootID)),
                                       new XElement(code,
                                                   new XAttribute(code, item.code.code.ToString()),
                                                   new XAttribute(codeSystem, item.code.codeSystem),
                                                   new XAttribute(displayName, item.code.displayName)),
                                       new XElement(title, item.title),
                                        item.allowText ? new XElement(text, item.text) : null,
                                       new XElement(effectiveTime, new XAttribute(value, item.effectiveTime)))
                   );

                if (structured != null)
                {
                    var firstNode = componentTag.Descendants(section).FirstOrDefault();
                    if (item.subSectionList != null && item.subSectionList.Count > 0)
                    {
                        foreach (var firstItem in item.subSectionList)
                        {
                            var firstComponentTag = new XElement(component,
                                                        new XElement(section, new XAttribute(ID, firstItem.sectionID),
                                                             new XElement(id, new XAttribute(root, item.sectionID)),
                                                             new XElement(code,
                                                                new XAttribute(code, firstItem.code.code.ToString()),
                                                                new XAttribute(codeSystem, firstItem.code.codeSystem),
                                                                new XAttribute(displayName, firstItem.code.displayName)),  
                                                             firstItem.allowTitle ? new XElement(title, firstItem.title) : null,
                                                             firstItem.allowText ? new XElement(text, firstItem.text) : null,
                                                             new XElement(effectiveTime, new XAttribute(value, firstItem.effectiveTime))
                                                ));

                            if (firstItem.subSectionList != null && firstItem.subSectionList.Count > 0)
                            {
                                var secondNode = firstComponentTag.Descendants(section).FirstOrDefault();
                                foreach (var secondItem in firstItem.subSectionList)
                                {
                                    var secondComponentTag = new XElement(component,
                                                                new XElement(section, new XAttribute(ID, secondItem.sectionID),
                                                                     new XElement(id, new XAttribute(root, firstItem.sectionID)),
                                                                     new XElement(code,
                                                                        new XAttribute(code, secondItem.code.code.ToString()),
                                                                        new XAttribute(codeSystem, secondItem.code.codeSystem),
                                                                        new XAttribute(displayName, secondItem.code.displayName)),
                                                                     new XElement(title, secondItem.title),
                                                                     secondItem.allowText ? new XElement(text, secondItem.text) : null,
                                                                     new XElement(effectiveTime, new XAttribute(value, secondItem.effectiveTime))
                                                        ));
                                    if (secondItem.subSectionList != null && secondItem.subSectionList.Count > 0)
                                    {
                                        var thirdNode = secondComponentTag.Descendants(section).FirstOrDefault();
                                        foreach (var thirdItem in secondItem.subSectionList)
                                        {
                                            var thirdComponentTag = new XElement(component,
                                                                        new XElement(section, new XAttribute(ID, thirdItem.sectionID),
                                                                             new XElement(id, new XAttribute(root, secondItem.sectionID)),
                                                                             new XElement(code,
                                                                                new XAttribute(code, thirdItem.code.code.ToString()),
                                                                                new XAttribute(codeSystem, thirdItem.code.codeSystem),
                                                                                new XAttribute(displayName, thirdItem.code.displayName)),
                                                                             new XElement(title, thirdItem.title),
                                                                             thirdItem.allowText ? new XElement(text, thirdItem.text) : null,
                                                                             new XElement(effectiveTime, new XAttribute(value, thirdItem.effectiveTime))
                                                                ));
                                            if (thirdNode != null)
                                            {
                                                thirdNode.Add(thirdComponentTag);
                                            }
                                        }
                                    }
                                    if (secondNode != null)
                                    {
                                        secondNode.Add(secondComponentTag);
                                    }

                                }
                            }
                            firstNode.Add(firstComponentTag);                         
                        }                        
                    }

                    structured.Add(componentTag);
                    foreach (var noeds in document.Root.Descendants())
                    {
                        if (noeds.Name.NamespaceName == "")
                        {
                            noeds.Attributes("xmlns").Remove();
                            noeds.Name = noeds.Parent.Name.Namespace + noeds.Name.LocalName;
                        }
                    }
                    SessionHelper.current.saveForm = document;
                }
            }

        }

        public void CreateAddress(List<Author> items)
        {
            XElement addressTag = null;
            // XElement newSubject = null;
            var document = SessionHelper.current.saveForm;
            var xmlns = XNamespace.Get("urn:hl7-org:v3");
            var authorNode = document.Root.Descendants(xmlns + author).FirstOrDefault();

            if (authorNode == null)
            {

            }
            if (items != null && items.Count > 0)
            {
                var item = items.Where(x => x.isRrepresentedAddress == true).FirstOrDefault();
                var assignedItems = items.Where(x => x.isRrepresentedAddress == false).ToList();
                addressTag = new XElement(assignedEntity,
                 new XElement(representedOrganization,
                    new XElement(id,
                        new XAttribute(root, item.companyRoot),
                        new XAttribute(extension, item.companyExtension)),
                    new XElement(id,
                        new XAttribute(root, item.roleRoot),
                        new XAttribute(extension, item.roleExtension)),
                    new XElement(id, 
                        new XAttribute(root, item.sponsorRoot), 
                        new XAttribute(extension, item.sponsorExtension)), 
                    new XElement(name, item.address.companyName),
                    new XElement(contactParty,
                            new XElement(addr,
                                new XElement(streetAddressLine, item.address.street),
                                new XElement(city, item.address.city),
                                new XElement(state, item.address.province),
                                new XElement(postalCode, item.address.postalCode),
                                new XElement(country, item.address.country)),
                            new XElement(telecom, new XAttribute(value, item.address.phone)),
                            new XElement(telecom, new XAttribute(value, item.address.emailAdress)),
                            new XElement(contactPerson, new XElement(name, item.address.contactName)))
                ));

                if (authorNode != null)
                {
                    authorNode.Add(addressTag);
                    foreach (var noeds in document.Root.Descendants())
                    {
                        if (noeds.Name.NamespaceName == "")
                        {
                            noeds.Attributes("xmlns").Remove();
                            noeds.Name = noeds.Parent.Name.Namespace + noeds.Name.LocalName;
                        }
                    }
                    SessionHelper.current.saveForm = document;
                }

                if (assignedItems != null && assignedItems.Count > 0)
                {
                    var assignedNode = authorNode.Descendants(xmlns + representedOrganization).FirstOrDefault();
                    if (assignedNode == null)
                    {
                        assignedNode = authorNode.Descendants(xmlns + representedOrganization).FirstOrDefault();
                    }
                    foreach (var assignedItem in assignedItems)
                    {
                        var assignedTag = new XElement(assignedEntity,
                                           new XElement(assignedOrganization,
                                               new XElement(assignedEntity,
                                                    new XElement(assignedOrganization,
                                                       new XElement(id,
                                                            new XAttribute(root, assignedItem.companyRoot),
                                                            new XAttribute(extension, assignedItem.companyExtension)),
                                                        new XElement(id,
                                                            new XAttribute(root, assignedItem.roleRoot),
                                                            new XAttribute(extension, assignedItem.roleExtension)),
                                                       new XElement(name, assignedItem.address.companyName),
                                                       new XElement(telecom, new XAttribute(value, assignedItem.address.phone)),
                                                       new XElement(telecom, new XAttribute(value,  assignedItem.address.emailAdress)),
                                                       new XElement(addr,
                                                           new XElement(streetAddressLine, assignedItem.address.street),
                                                           new XElement(city, assignedItem.address.city),
                                                           new XElement(state, assignedItem.address.province),
                                                           new XElement(postalCode, assignedItem.address.postalCode),
                                                           new XElement(country, assignedItem.address.country)),
                                                       new XElement(contactParty, new XElement(contactPerson, new XElement(name, assignedItem.address.contactName)))
                                                   ))
                                           ));
                        if (assignedNode != null)
                        {
                            assignedNode.Add(assignedTag);
                            foreach (var noeds in document.Root.Descendants())
                            {
                                if (noeds.Name.NamespaceName == "")
                                {
                                    noeds.Attributes("xmlns").Remove();
                                    noeds.Name = noeds.Parent.Name.Namespace + noeds.Name.LocalName;
                                }
                            }
                            SessionHelper.current.saveForm = document;
                        }
                    }                    
                }
            }
        }
    }
}