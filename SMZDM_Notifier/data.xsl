<?xml version="1.0" encoding="utf-8"?>

<xsl:stylesheet
  version="1.0"
  xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
  xmlns:content="http://purl.org/rss/1.0/modules/content/">
  <xsl:output method="html" indent="yes" doctype-system="http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"
              doctype-public="-//W3C//DTD XHTML 1.0 Transitional//EN" />
  <xsl:template match="/">
    <html>
      <head>
        <title>
          <xsl:value-of select="什么值得买" />
        </title>
        <style media="all" type="text/css">
          .ChannelTitle
          {
          font-weight:  bold;
          text-align:  center;
          padding-bottom:  16px;
          }

          .ArticleContainer
          {
          padding:  20px;
          border: 1px  solid #cccccc ;
          }

          .ArticleTitle
          {
          font-size:14px;
          font-weight:  bold;
          padding-left:  5px;
          padding-top:  5px;
          padding-bottom:  5px;
          border-bottom:  1px  solid #3165c6 ;
          }

          .ArticleHeader
          {
          padding:5px;
          color:#666666;
          }

          .ArticleDescription
          {
          padding:5px;
          }
          .ArticleFootor
          {
          padding-top:  5px;
          padding-bottom: 5px;
          }

          body{
          background-color:white;
          font-size:  14px;
          }
          a:link {
          color:#3165C6;
          text-decoration:none;
          }
          a:hover, a:active {
          color:#027AC6;
          text-decoration:none;
          }
          a:visited {
          text-decoration:none;
          }

          img{
          display:block;
          margin:20px auto;
          padding: 0px auto;
          width:expression(this.width>600?"600px":this.width);
          }
        </style>
      </head>
      <body>
        <!--<div class="ChannelTitle">
          <a href="{link}">
            <xsl:value-of select="title" />
          </a>
          <span>
            - <xsl:value-of select="description" />
          </span>
        </div>
        <xsl:apply-templates select="item" />
      </body>
    </html>
    memo:  <xsl:value-of select="author" />
  </xsl:template>-->

        <xsl:for-each select="items/item">
          <div class="ArticleContainer">
            <div class="ArticleTitle">
              <a href="{link}" target="_blank">
                <xsl:value-of select="title" />
              </a>
            </div>
            <div class="ArticleHeader">
              <xsl:value-of select="channel" /> | <xsl:value-of select="pubDate" />
            </div>

            <div class="ArticleDescription">
              <xsl:value-of select="content:encoded" disable-output-escaping="yes" />
            </div>
            <div class="ArticleFootor">
              <ul>
                <li class="comments">
                  <a href="{comments}" target="_blank">评论</a>
                </li>
              </ul>
            </div>
          </div>
          <br />
        </xsl:for-each>

      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>