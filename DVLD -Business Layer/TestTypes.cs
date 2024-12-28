using Data_Accses__Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD__Business_Layer
{
    public class TestTypess
    {
        public class TestTypes
        {
            public enum enMode { AddNew = 0, Update = 1 };
            public enMode Mode = enMode.AddNew;
            public enum enTestType { VisionTest=1,WrittenTest=2,StreetTest=3};
            public TestTypes. enTestType TestTypeID {  get; set; }
     public        string TestTypeDescription { get; set; }
           public decimal TestTypeFees { get; set; }
            public  string TestTypeTitle { get; set; }
            
            public TestTypes()
            {



                this.TestTypeID = TestTypes.enTestType.VisionTest;
                this.TestTypeDescription = "";
                this.TestTypeFees =0;
                this.TestTypeTitle="";  
                Mode = enMode.AddNew;

            }

            private TestTypes(TestTypes.enTestType TestTypeID, string TestTypeDescription, decimal TestTypeFees, string TestTypeTitle )
            {
                this.TestTypeID = TestTypeID;
                this.TestTypeDescription = TestTypeDescription;
                this.TestTypeFees = TestTypeFees;
               this.TestTypeTitle = TestTypeTitle;
                 Mode = enMode.Update;
            }
            private bool _AddNewTest()
            {
                //call DataAccess Layer 

                this.TestTypeID = (TestTypes.enTestType)TestTypesData.AddNewTestTypes( this.TestTypeDescription, this.TestTypeFees, this.TestTypeTitle);

                return (this.TestTypeTitle !="");
            }

            private bool _UpdateTest()
            {
                //call DataAccess Layer 

                return TestTypesData.UpdateTestTypes((int)this.TestTypeID, this.TestTypeDescription, this.TestTypeFees, this.TestTypeTitle );

            }

            public static TestTypes Find(TestTypes.enTestType TestTypeID)
            {

                string TestTypeDescription = "";
                 decimal TestTypeFees = 0;
                string TestTypeTitle = "";
              
              
                if (TestTypesData.GetTestTypesInfoByID((int)TestTypeID,ref TestTypeDescription ,ref TestTypeFees,ref TestTypeTitle))

                    return new TestTypes(TestTypeID, TestTypeDescription, TestTypeFees, TestTypeTitle);
                else
                    return null;

            }




            public bool Save()
            {


                switch (Mode)
                {
                    case enMode.AddNew:
                        if (_AddNewTest())
                        {

                            Mode = enMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    case enMode.Update:

                        return _UpdateTest();

                }




                return false;
            }

            public static DataTable GetAllTestTypes()
            {
                return TestTypesData.GetAllTestTypes();

            }

            public static bool DeleteTestTypes(int ID)
            {
                return TestTypesData.DeleteTestTypes(ID);
            }

         

        }
    }

    }
