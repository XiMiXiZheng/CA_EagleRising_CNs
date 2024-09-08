<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output omit-xml-declaration="yes"/>
	<xsl:template match="@*|node()">
		<xsl:copy>
			<xsl:apply-templates select="@*|node()"/>
		</xsl:copy>
	</xsl:template>
	<xsl:template match="Items/Item[@id='cla_germ_longbow_90']/@name">
		<xsl:attribute name="name">{=wyfZwO5k}[Germanic]90 Pound Longbow</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='cla_germ_longbow_140']/@name">
		<xsl:attribute name="name">{=SUI4Ees3}[Germanic]140 Pound War Longbow</xsl:attribute>
	</xsl:template>
</xsl:stylesheet>