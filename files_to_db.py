# -*- coding: utf-8 -*-
import io
import os
import mysql.connector
from mysql.connector import Error
from mysql.connector import errorcode


path = 'C:\\Users\\peter\\Desktop\\3015_jpeg\\'


def convertToBinaryData(filename):
    #Convert digital data to binary format
    with open(filename, 'rb') as file:
        binaryData = file.read()
    return binaryData



def insertBLOB(name, photo):
    print("Inserting BLOB into symbol table")
    try:
        connection = mysql.connector.connect(host='sql.autodl.de',
                             database='leltar',
                             user='ppeti',
                             password='ppeti')
        cursor = connection.cursor(prepared=True)
        sql_insert_blob_query = """ INSERT INTO `symbol`
                          (`name`, `image`) VALUES (%s,%s)"""
        sympicture = convertToBinaryData(photo)
        
        # Convert data into tuple format
        insert_blob_tuple = (name, sympicture)
        result  = cursor.execute(sql_insert_blob_query, insert_blob_tuple)
        connection.commit()
        print ("Image inserted successfully as a BLOB into symbol table", result)
    except mysql.connector.Error as error :
        connection.rollback()
        print("Failed inserting BLOB data into MySQL table {}".format(error))
    finally:
        #closing database connection.
        if(connection.is_connected()):
            cursor.close()
            connection.close()
            print("MySQL connection is closed")


for r, d, f in os.walk(path):
    for file in f:
        if '.jpg' in file:            
            utvonal = path + file
            nev = os.path.splitext(file)[0]
            insertBLOB(nev, utvonal)
            
            
