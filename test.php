<p>для send_and_load.php</p>
<form method='post' action='send_and_load.php'>
<input type="text" value="data2.txt" name="filename">
<input type="submit" name="submit" value="Ok">
</form>


<p>ajax_test</p>
<form method='post' action='http://192.168.10.10:8000/route' enctype="application/x-www-form-urlencoded">
<input type="text" value="[[12.34,26.57],[23.34,29.48]]" name="data">
<input type="submit" name="submit" value="Ok">
</form>

<hr/>
<h3>ajax by native js</h3>
<button id="send">Send</button>
<script type="text/javascript">
var Ajax = 
{
    getXMLHttp: function(){
        var xmlHttp
        try
        {
            //Firefox, Opera 8.0+, Safari
            xmlHttp = new XMLHttpRequest();
        }catch(e){
            //Internet Explorer
            try{
                xmlHttp = new ActiveXObject("Msxml2.XMLHTTP");
                }catch(e){
                try{
                    xmlHttp = new ActiveXObject("Microsoft.XMLHTTP");
                }catch(e){
                    alert("Your browser does not support AJAX!");
                    return false;
                }
            }
        }
        return xmlHttp;
    },

    
    sendRequest: function(method, url, params, callback){
        XMLHttp = Ajax.getXMLHttp();
        XMLHttp.open(method, url, true)
        XMLHttp.onreadystatechange = function(){
            if ( XMLHttp.readyState == 4 ){
                if ( XMLHttp.status == 200 ){
                    callback(JSON.parse(XMLHttp.responseText));
                }
                else{
                    callback(null);
                }
            }
        };
        
        XMLHttp.setRequestHeader('Content-type', 'application/x-www-form-urlencoded');
        XMLHttp.send(params);
    }
    
};

var params = 'data=[[12.34,26.57],[23.34,29.48]]';
document.getElementById('send').onclick = function(){ 
	Ajax.sendRequest('POST', 'http://192.168.10.10:8000/route', params, function(result){alert(result)}); 
};

</script>