# ALIRO
##### A [BERT](https://bert-toolkit.com/) based tool to use custom R analysis

## What is ALIRO?

ALIRO is a free BERT-based tool to use custom R code in different analysis, including time series and random forest analysis.It's build using VSTO, C#, R and BERT.

## How ALIRO born?

ALIRO born in Costa Rica thanks to Minor Bonilla, CEO at [Buklolab](http://www.buklolab.com/). We build this version while doing our business practice at this company, to graduate from Bachelor's degree from bussiness computing

## What is our objective?
Our objective is to bring a scalable free-tool to use custom **R** code in excel, so everyone who have knowledge in excel can use this tool without a lot of technical skills.



## HOW TO USE 
Note: **__ALIRO _STILL_ IN DEV__** some bugs will occur - See Common errors section if something went wrong

Before start: ALIRO is based on BERT and R, so we need this two dependencies to continue with ALIRO instalation. Do not worry, the installer will help you in this process.

1. First, download the installer in your desired lang. [ALIRO-EN](https://download1647.mediafire.com/gmjvo1ckn9zg/88cx9dd38s8tpam/ALIR0_ENG.msi) or [ALIRO-ESP](https://download1518.mediafire.com/iabec8aj3jbg/v1d65sce6v6867h/ALIR0_ESP.msi)
2. Follow the instructions and download the required files
3. Install
4. If everything were ok, ALIRO is ready to use in your EXCEL app

**Depending on your antivirus/firewall, windows will show an alert message telling you about *unknow author* do not worry about it, it is safe.**

## COMMON ERRORS
It is the first version of ALIRO so many bugs will occur, but we know some of them and we still developing solutions to it. There are some common errors that we know:

##### **Installed ALIRO but it does not appear in EXCEL**
If everything during instalation were ok, you should:
1. Open excel
2. Go to File > Settings > Complements
3. In complements, choose **COM Complements** and click GO
4. You will se a complement called **ALIRO**, select it and click OK

##### **Installed ALIRO but functions are not working**
Sometimes the installer will fail installing the .R functions at the desired route. It is because windows use two routes to define Documents access, for example: If you're on windows 8 or 10 it will be Installed at **OneDrive/Documents**, and it **needs to be installed at** **_C:\Users\<user>\Documents_**, so, if you're getting this error:
1. Search at **_C:\Users\<user>\Documents\BERT2\functions_** If you don't see .R functions go to:  
2. Search at **_C:\Users\<user>\OneDrive\Documents\BERT2\_** Copy this folder
3. Go to **_C:\Users\<user>\Documents\__** and paste the **BERT2** folder here and replace the files
##### **ALIRO is working but SQL Select queries are not working**
SQLSelect queries to extract data from your database will only work at local databases at the moment, so 
if you want to use it you neet to install it in your machine

##### **I'm getting -2146826273 result**
This error is not an issue of ALIRO Application side, it is an error that is returning R and will be made by:
1. Wrong data
2. Functions Files .R are not accesible
3. An error made by us while coding .R functions



