import React from 'react';
import { hot } from 'react-hot-loader/root'
import { Button } from 'semantic-ui-react'
import ugcClient from 'agility-ugc'

class UGCTestComponent extends React.Component {
    render() {
        
        ugcClient.GetRecord(1027, function(data) {	
	
            if (data.ResponseType != ugcClient.ResponseType.OK) {
                //error occurred
                alert("An error occurred: " + data.Message);			
            } else {
                //data.ResponseData is a "Record" object
                var record = data.ResponseData;
                console.log(record)	;
            }
        })

        //search for records in the "Profiles" Website User Type table
        //only return 10 records at a time
        //start at the beginning of the results
        //find record that have FirstName starting with Joe

        var searchArg = new ugcClient.SearchArg();
        searchArg.RecordTypeName = "SiteFeedback";
        searchArg.PageSize = 10; 
        searchArg.RecordOffset= 0; 
        searchArg.Search = "";		

        //if the data should be cached based on a custom key...
        searchArg.CacheKey = "MyCustomCacheKey"; //TODO: calculate this key value, and only use if necessary.

        //invoke the SearchRecords method, which is asynchronous, and has a callback
        ugcClient.SearchRecords(searchArg, function(data) {	
            
            if (data.ResponseType != ugcClient.ResponseType.OK) {
                //error occurred
                alert("An error occurred: " + data.Message);			
            } else {
                console.log(data);
                //data.ResponseData is a "PagedResult" object 
                //with Records and TotalRecords properties.
                var records = data.ResponseData.Records;
                var totalRecords= data.ResponseData.TotalRecords; 
            }
        });
        
        return (
            <div className="container">
                <h1>UGC Test Component</h1>
            </div>
        );
    }
}
export default hot(UGCTestComponent);
