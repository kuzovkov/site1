$(function(){

var selectedPlaces = new Array();
var MAX_PLACES = 5;
var PLACES_LIMIT_ENABLED = false;
var ROW = 0;
var PLACE = 1;
var VIP_ROW = 14;
var VIP_PLACES = [ '1-2', '3-4', '5-6', '7-8', '9-10', '11-12', '13-14', '15-16', '17-18', '19-20' ];

$('.place').click(function(){ 
								
								$(this).toggleClass('selected');
								var place = parseInt(this.id);
								var div = $(this).parents('.row');
								var row = parseInt(div.attr('id'));
								if ( $(this).hasClass( 'selected' ) )
								{
									addPlace( row, place );
								}
								else
								{
									delPlace( row, place );
								}
								if ( PLACES_LIMIT_ENABLED )
								{
									if ( !checkMaxPlaces() )
									{
										$(this).removeClass('selected');
										delPlace( row, place );
									}
								}
								printSelected();
							});


$('#send-selected').click( function(){
										
										var data = '{';
										for ( i = 0; i < selectedPlaces.length; i++ )
										{
											data += selectedPlaces[i][ROW] + ':' + selectedPlaces[i][PLACE];
											if ( i < selectedPlaces.length - 1 ) data += ','
										}
										data += '}';
										$('#result').load('handler.php',{data:data});

									});
									
$(document).tooltip();
							
function checkMaxPlaces()
{
	return ( selectedPlaces.length <= MAX_PLACES )? true : false;
}
							
function addPlace( row, place )
{
	selectedPlaces.push([row,place]);
}

function delPlace( row, place )
{
	for ( i = 0; i < selectedPlaces.length; i++ )
	{
		var isNeedlePlace = ( selectedPlaces[i][ROW] == row ) && ( selectedPlaces[i][PLACE] == place )
		if ( isNeedlePlace )
		{
			selectedPlaces.splice(i,1);
			break;
		}		
	}
}
							
function printSelected()
{
	var outputString = '';
	for ( i = 0; i < selectedPlaces.length; i++ )
	{
		if ( selectedPlaces[i][ROW] == VIP_ROW )
		{
			outputString +=  selectedPlaces[i][ROW] + ' ряд/' + VIP_PLACES[ selectedPlaces[i][PLACE] - 1 ] + ' место; ';
		}
		else
		{
			outputString +=  selectedPlaces[i][ROW] + ' ряд/' + selectedPlaces[i][PLACE] + ' место; ';
		}
		
	}
	$('#selected-place').html(outputString);
}						
							
});//end ready