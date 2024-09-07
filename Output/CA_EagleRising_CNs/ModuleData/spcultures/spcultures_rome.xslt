<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output omit-xml-declaration="yes"/>
    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>
    </xsl:template>
    <!--原MOD罗马文化使用骑砍2原版帝国文化的StringID，导致汉化不能覆盖生效，所以用此xslt文件更改罗马StringID，用以汉化-->
    <xsl:template match="Culture[@id='empire']/@name">
        <xsl:attribute name="name">{=5nTR6cuj}Calradii</xsl:attribute>
    </xsl:template>
    
</xsl:stylesheet>