<?php
backup_database_tables('localhost','root','root','site3', '*');
// backup the db function
function backup_database_tables($host,$user,$pass,$name,$tables)
{
        $link = mysql_connect($host,$user,$pass);
        mysql_select_db($name,$link);
        //get all of the tables
        if($tables == '*')
        {
                $tables = array();
                $result = mysql_query('SHOW TABLES');
                while($row = mysql_fetch_row($result))
                {
                        $tables[] = $row[0];
                }
        }
        else
        {
                $tables = is_array($tables) ? $tables : explode(',',$tables);
        }
        //cycle through each table and format the data
        $return = '';
		foreach($tables as $table)
        {
                
				$result = mysql_query('SELECT * FROM '.$table);
                $num_fields = mysql_num_fields($result);
                $return .= 'DROP TABLE IF EXISTS '.$table.';';
                $row2 = mysql_fetch_row(mysql_query('SHOW CREATE TABLE '.$table));
                $return.= "\n\n".$row2[1].";\n\n";
                for ($i = 0; $i < $num_fields; $i++)
                {
                        while($row = mysql_fetch_assoc($result))
                        {
                                
								print_r($row);
								$return.= 'INSERT INTO '.$table.' SET ';
                                //for($j=0; $j<$num_fields; $j++)
								$j=0;
								foreach( $row as $key=>$value )
                                {
                                        
										$value = addslashes($value);
                                        $value = ereg_replace("\n","\\n",$value);
                                        if ( isset($value) && !empty($value) )
										{ 
											if ( is_string($value) )
											{
												$return.= "`$key`='{$value}'"; 
											}
											else
											{
												$return.= "`$key`={$value}";
											}
											
										}
										$j++;
                                        if ( $j < $num_fields && !empty($value) ) { $return.= ','; }
                                }
                                $return.= ";\n";
                        }
                }
                $return.="\n\n\n";
        }
        //save the file
        $handle = fopen('db-backup-'.time().'-'.(md5(implode(',',$tables))).'.sql','w+');
        fwrite($handle,$return);
        fclose($handle);
}
?>