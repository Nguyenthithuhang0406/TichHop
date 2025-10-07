<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html"/>
	<xsl:template match="/">
	<html>
		<body>
			<b>Tổng 2 số là:</b>
			<xsl:value-of select="/GOC/SO[1]"/> +
			<xsl:value-of select="/GOC/SO[2]"/> =
			<xsl:value-of select="/GOC/SO[1] + /GOC/SO[2]"/>
		</body>
	</html>
	</xsl:template>
    <xsl:template match="@* | node()">
        <xsl:copy>
            <xsl:apply-templates select="@* | node()"/>
        </xsl:copy>
    </xsl:template>
</xsl:stylesheet>
