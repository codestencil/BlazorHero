using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using ZeraSystems.CodeNanite.Expansion;
using ZeraSystems.CodeStencil.Contracts;

namespace MyOrganization.BlazorHero
{
    /// <summary>
    /// </summary>
    [Export(typeof(ICodeStencilCodeNanite))]
    [CodeStencilCodeNanite(new[]
    {
        // 0 - Publisher: This is the name of the publisher
        "MyOrganization Inc.",                    
        // 1 - Title: This is the title of the Code Nanite
        "BlazorHero Stencil",    
        // 2 - Details: This is the description of the Code Nanite/Plugin
        "Code Nanite/Plugin for BlazorHero Stencil",
        // 3 - Version Number
        "1.0",                                 
        // 4 - Label: Label of the Code Nanite
        "SamplePlugin",                         
        // 5 - Namespace
        "MyOrganization.BlazorHero",  
        // 6 - Release Date
        "04-02-2021",                          
        // 7 - Name to use for Expander Label
        "CS_SAMPLE_FUNCTION",                     
        // 8 - Indicates that the Nanite is Schema Dependent
        "0",                                   
        // 9 - RESERVED
        "",                                    
        // 10 - link to Online Help
        ""                                    
    })]
    public partial class SamplePlugin : ExpansionBase, ICodeStencilCodeNanite
    { 
        public string Input { get; set; }
        public string Output { get; set; }
        public int Counter { get; set; }
        public List<string> OutputList { get; set; }
        public List<ISchemaItem> SchemaItem { get; set; }
        public List<IExpander> Expander { get; set; }
        public List<string> InputList { get; set; }

        public void ExecutePlugin()
        {
            Initializer(SchemaItem, Expander);
            MainFunction();
            Output = ExpandedText.ToString();
        }

    }
}

