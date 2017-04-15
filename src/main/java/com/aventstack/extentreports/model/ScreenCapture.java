package com.aventstack.extentreports.model;

public class ScreenCapture extends Media { 

    private static final long serialVersionUID = -3413285738443448335L;

    public String getSource() {
        return "<img data-featherlight='" + getPath() + "' data-featherlight-content='" + getName() + "' width='10%' src='' data-src='" + getPath() + "'>";
    }
    
    public String getSourceWithIcon() {
        return "<a href='#' data-featherlight='" + getPath() + "' data-featherlight-content='" + getName() + "'><i class='material-icons'>photo</i></a>";
    }

}
