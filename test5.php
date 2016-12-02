<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
   "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

  <head>
  
    <title>Mashup Example: Relief-Water Map with Labels</title>
    
    <meta http-equiv="content-type" content="text/html; charset=utf-8">
    
    <script src="http://maps.google.com/maps?file=api&amp;v=2&amp;key=ABQIAAAAg1IhcBOuBSkJN-sU2UAdXhSWx-VDM6NTKXoUsLfDjYylQksEQhQ3PU5jwuW-W47KvfJB0-84R8u6fQ" type="text/javascript"></script>

    <script type="text/javascript">
      function load() {
        if (GBrowserIsCompatible()) {

            var min = 0;
            var max = 12;

            var license = "<a href='http://www.maps-for-free.com/html/about.html' target='_blank'>License</a>";
            var copyright = new GCopyright(1, new GLatLngBounds(new GLatLng(-90, -180), new GLatLng(90, 180)), 0, license);
            var copyrightCollection = new GCopyrightCollection("Relief Maps: ");
            copyrightCollection.addCopyright(copyright);

            // Relief Map
            var relief = [new GTileLayer(copyrightCollection, min, max)];
            relief[0].getTileUrl = function(a,b) {
              return "http://maps-for-free.com/layer/relief/z" + b + "/row" + a.y + "/" + b + "_" + a.x + "-" + a.y + ".jpg"; };
            reliefLayer = new GMapType(relief, G_SATELLITE_MAP.getProjection(), "Relief", {minResolution:min, maxResolution:max});

            // Water Layer
            function getWaterLayer() {
              var layer = new GTileLayer(copyrightCollection, min, max);
              layer.getTileUrl = function (a,b) {
                return "http://maps-for-free.com/layer/water/z" + b + "/row" + a.y + "/" + b + "_" + a.x + "-" + a.y + ".gif"; };
              return layer;
            }
            
            var map = new GMap2(document.getElementById("map"));
            map.setCenter(new GLatLng(55, 80), 4);

            // Add Water Layer
            waterLayer = new GTileLayerOverlay(getWaterLayer());
            map.addOverlay(waterLayer);
            waterLayer.visible = true;

            // Add Label Layer
            labelLayer = new GTileLayerOverlay(G_HYBRID_MAP.getTileLayers()[1]);
            map.addOverlay(labelLayer);
            labelLayer.visible = true;

            map.addMapType(reliefLayer);
            map.addControl(new GLargeMapControl());
            map.addControl(new GOverviewMapControl());
            map.addControl(new GScaleControl());
            map.setMapType(reliefLayer);

            map.enableDoubleClickZoom();
            map.enableContinuousZoom();
            map.enableScrollWheelZoom();
        }
      }
    </script> 
    
  </head>

  <body onload="load()" onunload="GUnload()">  
  
    <span style='color:darkRed; font-size:11px;font-weight:bold;'>
    How to upgrade Google Maps Applications with Relief Maps see
    <a href="http://www.maps-for-free.com/html/example.txt">
    <span style='color:darkBlue;'>Example Code</span></a>

    <p>
    <div id="map" style="width:500px; height:500px"></div>
  </body>
</html>