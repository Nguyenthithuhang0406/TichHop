<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
	<xsl:output method="html" indent="yes"/>

	<xsl:template match="/">
		<html>
			<head>
				<title>Giải phương trình bậc nhất</title>
				<br/>
			</head>
			<body>
				<h2>Giải phương trình bậc nhất: aX + b = 0</h2>
				<br/>
				<p>
					Hệ số a = <xsl:value-of select="/goc/hsa"/> <br/>
					<p>
						Hệ số b = <xsl:value-of select="/goc/hsb"/> <br/>
					</p>
				</p>

				<xsl:variable name="a" select="/goc/hsa"/>
				<xsl:variable name="b" select="/goc/hsb"/>

				<xsl:if test="$a = 0 and $b = 0">
					<p>Phuong trinh vo so nghiem</p>
				</xsl:if>

				<xsl:if test="$a = 0 and $b != 0">
					<p>Phuong trinh vo nghiem</p>
				</xsl:if>

				<xsl:if test="$a != 0">
					<p>
						Phương trình có nghiệm duy nhất:
						<br/>
						X = <xsl:value-of select="-$b div $a"/>
					</p>
				</xsl:if>
			</body>
		</html>
	</xsl:template>

	<xsl:template match="@* | node()">
		<xsl:copy>
			<xsl:apply-templates select="@* | node()"/>
		</xsl:copy>
	</xsl:template>
</xsl:stylesheet>
