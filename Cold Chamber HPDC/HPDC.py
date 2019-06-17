import math
'''
This software calculate the gating system dimensions with optimum gate and over flow positions for cold chamber HPDC.
The software works only on certain shapes i.e.(Parallelogram, Cylinder, Hexagonal).
The software needs to know part dimensions and shape with mold working temperatures and choose the the machine available.
A pre-defined machines data base is available for user selection.
'''
def machine_parameters(input_data):
    '''
    This function consider as a pre-defined database for the machine data
    it needs the machine capacity and returns all machine data
    '''
    #define machine data fields
    machine_data={'locking_force':int(),'injection_force':int(),'plunger_diameter':[int(),int()],'injection_speed_range':[float(),float()],'plunger_stroke':int(),'injection_volume':[int(),int()],'metal_pressure':[[float(),float()],[float(),float()],[float(),float()]],'cast_area':[[float(),float()],[float(),float()],[float(),float()]]}
    #data for 150 TON machine
    if input_data['machine_capacity']=='150TON':
        machine_data['locking_force']=1500
        machine_data['injection_force']=182
        machine_data['plunger_diameter']=[45,50,60]
        machine_data['injection_speed_range']=[0.1,7]
        machine_data['plunger_stroke']=340
        machine_data['injection_volume']=[362*1000,447*1000,644*1000]
        machine_data['metal_pressure'][0]=[522*(10**5)/((10**6)*1000),1056*(10**5)/((10**6)*1000)]
        machine_data['metal_pressure'][1]=[422*(10**5)/((10**6)*1000),856*(10**5)/((10**6)*1000)]
        machine_data['metal_pressure'][2]=[293*(10**5)/((10**6)*1000),594*(10**5)/((10**6)*1000)]
        machine_data['cast_area'][0]=[239*100,118*100]
        machine_data['cast_area'][1]=[296*100,146*100]
        machine_data['cast_area'][2]=[426*100,210*100]
        return machine_data
    #data for 250 TON machine
    elif input_data['machine_capacity']=='250TON':
        machine_data['locking_force']=2500
        machine_data['injection_force']=270
        machine_data['plunger_diameter']=[50,60,70]
        machine_data['injection_speed_range']=[0.1,7]
        machine_data['plunger_stroke']=420
        machine_data['injection_volume']=[540*1000,777*1000,1058*1000]
        machine_data['metal_pressure'][0]=[687*(10**5)/((10**6)*1000),1374*(10**5)/((10**6)*1000)]
        machine_data['metal_pressure'][1]=[477*(10**5)/((10**6)*1000),954*(10**5)/((10**6)*1000)]
        machine_data['metal_pressure'][2]=[350*(10**5)/((10**6)*1000),700*(10**5)/((10**6)*1000)]
        machine_data['cast_area'][0]=[363*100,181*100]
        machine_data['cast_area'][1]=[524*100,262*100]
        machine_data['cast_area'][2]=[714*100,357*100]
        return machine_data
    #data for 420 TON machine
    elif input_data['machine_capacity']=='420TON':
        machine_data['locking_force']=4200
        machine_data['injection_force']=350
        machine_data['plunger_diameter']=[60,70,80]
        machine_data['injection_speed_range']=[0.1,7]
        machine_data['plunger_stroke']=500
        machine_data['injection_volume']=[904*1000,1230*1000,1607*1000]
        machine_data['metal_pressure'][0]=[600*(10**5)/((10**6)*1000),1200*(10**5)/((10**6)*1000)]
        machine_data['metal_pressure'][1]=[441*(10**5)/((10**6)*1000),882*(10**5)/((10**6)*1000)]
        machine_data['metal_pressure'][2]=[337*(10**5)/((10**6)*1000),674*(10**5)/((10**6)*1000)]
        machine_data['cast_area'][0]=[584*100,292*100]
        machine_data['cast_area'][1]=[794*100,397*100]
        machine_data['cast_area'][2]=[1036*100,518*100]
        return machine_data
    #data for 500 TON machine
    elif input_data['machine_capacity']=='500TON':
        machine_data['locking_force']=5000
        machine_data['injection_force']=500
        machine_data['plunger_diameter']=[70,80,90]
        machine_data['injection_speed_range']=[0.1,7]
        machine_data['plunger_stroke']=630
        machine_data['injection_volume']=[1788*1000,2336*1000,2956*1000]
        machine_data['metal_pressure'][0]=[707*(10**5)/((10**6)*1000),1416*(10**5)/((10**6)*1000)]
        machine_data['metal_pressure'][1]=[541*(10**5)/((10**6)*1000),1084*(10**5)/((10**6)*1000)]
        machine_data['metal_pressure'][2]=[427*(10**5)/((10**6)*1000),857*(10**5)/((10**6)*1000)]
        machine_data['cast_area'][0]=[919*100,459*100]
        machine_data['cast_area'][1]=[1201*100,599*100]
        machine_data['cast_area'][2]=[1522*100,775*100]
        return machine_data
    #data for 650 TON machine
    elif input_data['machine_capacity']=='650TON':
        machine_data['locking_force']=6500
        machine_data['injection_force']=545
        machine_data['plunger_diameter']=[70,80,90]
        machine_data['injection_speed_range']=[0.1,7]
        machine_data['plunger_stroke']=630
        machine_data['injection_volume']=[1788*1000,2336*1000,2956*1000]
        machine_data['metal_pressure'][0]=[707*(10**5)/((10**6)*1000),1416*(10**5)/((10**6)*1000)]
        machine_data['metal_pressure'][1]=[541*(10**5)/((10**6)*1000),1084*(10**5)/((10**6)*1000)]
        machine_data['metal_pressure'][2]=[427*(10**5)/((10**6)*1000),857*(10**5)/((10**6)*1000)]
        machine_data['cast_area'][0]=[919*100,459*100]
        machine_data['cast_area'][1]=[1201*100,599*100]
        machine_data['cast_area'][2]=[1522*100,775*100]
        return machine_data
    #no further data
    else:
        return machine_data
def part_paramters(input_data):
        '''
        This function is to calculate the part volume, projection area and maximum gate width allowed
        The fuction needs part paramters and shape to return the calculated data
        '''
        #define part data fields
        part_data={'volume':float(),'projection_area':float(),'max_gate_width':float(),'thickness':input_data['thickness']}
        #data for Parallelogram
        if input_data['shape']=='Parallelogram':
            #calculate volume of the part
            part_data['volume']=input_data['width']*input_data['length']*input_data['height']-((input_data['width']-2*input_data['thickness'])*(input_data['length']-2*input_data['thickness'])*(input_data['height']-input_data['thickness']))
            #calculate projected area of the part
            part_data['projection_area']=input_data['width']*input_data['length']
            #define maximum gate width allowed to this shape
            part_data['max_gate_width']=input_data['width']
        #data for Cylinder
        elif input_data['shape']=='Cylinder':
            #calculate volume of the part
            part_data[{'volume'}]=((math.pi/4)*(input_data['diameter']**2 )*input_data['height'])-((math.pi/4)*((input_data['diameter']-2*input_data['thickness'])**2)*(input_data['height']-input_data['thickness']))
            #calculate projected area of the part
            part_data['projection_area']=(math.pi/4)*(input_data['diameter']**2)
            #define maximum gate width allowed to this shape
            part_data['max_gate_width']=input_data['diameter']*0.4
        #data for Hexagonal
        elif input_data['shape']=='Hexagonal':
            #calculate volume of the part
            part_data[{'volume'}]=((math.pi/4)*(input_data['width']**2 )*input_data['height'])-((math.pi/4)*((input_data['width']-2*input_data['thickness'])**2)*(input_data['height']-input_data['thickness']))
            #calculate projected area of the part
            part_data['projection_area']=(math.sqrt(3)/2)*(input_data['width']**2)
            #define maximum gate width allowed to this shape
            part_data['max_gate_width']=input_data['width']*math.sqrt(3)
        #return calculated data
        return part_data
def intial_parameters(input_data,part_data):
    '''
    This function for set the intial parameters for the gating system calculation
    '''
    #define intial data fields
    intial_data={'s':float(),'gate_velocity':float(),'k':float(),'z':float(),'cd':[float(),float()],'overflow_gateland':float(),'overflow_gatelength':float(),'overflow_gateheight':float(),'overflow_volume':float(),'vent_height':float(),'gate_thickness':[float(),float()],'density':float(),'flow_angle':float(),'gate_land':float(),'metal_temp_gate':float(),'min_metal_temp':float(),'mold_temp':float()}
    #set data for AlSi12 (230) part material
    if input_data['material']=='AlSi12 (230)':
        #set s parameter
        if input_data['thickness']<0.75:
            intial_data['s']=0.05
        elif 0.75<=input_data['thickness']<1.25:
            intial_data['s']=0.15
        elif 1.25<=input_data['thickness']<2:
            intial_data['s']=0.25
        elif 2<=input_data['thickness']<3.15:
            intial_data['s']=0.35
        else:
            intial_data['s']=0.5
        #set the gate velocity
        intial_data['gate_velocity']=1500*25.4/1000
        #set k parameter
        intial_data['k']=0.0346
        #set z parameter
        intial_data['z']=4.8
        #set cd parameter
        intial_data['cd']=[0.45,0.5]
        #set overflow parameters
        intial_data['overflow_gateland']=2
        intial_data['overflow_gatelength']=5
        intial_data['overflow_gateheight']=0.6
        #set vent height
        intial_data['vent_height']=0.15
        #set gate thickness limits
        intial_data['gate_thickness']=[0.8,3]
        #set part density
        intial_data['density']=2.76
        #set flow angle
        intial_data['flow_angle']=35
        #set gate land
        intial_data['gate_land']=1.5
        #set metal temperature at the gate
        intial_data['min_metal_temp']=580
    #set data for ZnAl4 (ZA3) part material
    elif input_data['material']=='ZnAl4 (ZA3)':
        #set s parameter
        if input_data['thickness']<0.75:
            intial_data['s']=0.1
        elif 0.75<=input_data['thickness']<1.25:
            intial_data['s']=0.15
        elif 1.25<=input_data['thickness']<2:
            intial_data['s']=0.225
        elif 2<=input_data['thickness']<3.15:
            intial_data['s']=0.275
        else:
            intial_data['s']=0.35
        #set the gate velocity
        intial_data['gate_velocity']=1850*25.4/1000
        #set k parameter
        intial_data['k']=0.0346
        #set z parameter
        intial_data['z']=2.5
        #set cd parameter
        intial_data['cd']=[0.45,0.5]
        #set overflow parameters
        intial_data['overflow_gateland']=2
        intial_data['overflow_gatelength']=5
        intial_data['overflow_gateheight']=0.6
        #set vent height
        intial_data['vent_height']=0.15
        #set gate thickness limits
        intial_data['gate_thickness']=[0.2,3]
        #set part density
        intial_data['density']=6.7
        #set flow angle
        intial_data['flow_angle']=35
        #set gate land
        intial_data['gate_land']=1.5
        #set metal temperature at the gate
        intial_data['min_metal_temp']=380
    #in case of material not found return nothing
    else:
        return intial_data
    #set overflow volume
    if input_data['thickness']<0.9:
        intial_data['overflow_volume']=part_data['volume']*1.5
    elif 0.9<=input_data['thickness']<1.3:
        intial_data['overflow_volume']=part_data['volume']*1.5
    elif 1.3<=input_data['thickness']<1.8:
        intial_data['overflow_volume']=part_data['volume']*1.5
    elif 1.8<=input_data['thickness']<2.5:
        intial_data['overflow_volume']=part_data['volume']*0.5
    elif 2.5<=input_data['thickness']<3.2:
        intial_data['overflow_volume']=part_data['volume']*0.25
    else:
        intial_data['overflow_volume']=0
    return intial_data
def cavities_numbers(intial_data,part_data,machine_data):
    '''
    This function to calculate maximum number of cavities allowed for the part data and selected machine
    '''
    #define intial fields
    cavity_data={'max_filling_time':float(),'max_ncavities':[int(),int(),int()]}
    #calculate maximum filling time
    cavity_data['max_filling_time']=intial_data['k']*((intial_data['metal_temp_gate']-intial_data['min_metal_temp']+intial_data['s']*intial_data['z'])/(intial_data['min_metal_temp']-intial_data['mold_temp']))*part_data['thickness']
    #maximum number of cavities due to volume
    volume_ncavities=[float(),float(),float()]
    volume_ncavities[0]=machine_data['injection_volume'][0]/((part_data['volume']+intial_data['overflow_volume'])*1.2)
    volume_ncavities[1]=machine_data['injection_volume'][1]/((part_data['volume']+intial_data['overflow_volume'])*1.2)
    volume_ncavities[2]=machine_data['injection_volume'][2]/((part_data['volume']+intial_data['overflow_volume'])*1.2)
    #maximum number of cavities due to flow
    flow_ncavities=[float(),float(),float()]
    piston_flow=[float(),float(),float()]
    piston_flow[0]= machine_data['injection_speed_range'][1]*0.8*1000*((math.pi/4)*machine_data['plunger_diameter'][0]**2)
    piston_flow[1]= machine_data['injection_speed_range'][1]*0.8*1000*((math.pi/4)*machine_data['plunger_diameter'][1]**2)
    piston_flow[2]= machine_data['injection_speed_range'][1]*0.8*1000*((math.pi/4)*machine_data['plunger_diameter'][2]**2)
    flow_ncavities[0]=piston_flow[0]/((part_data['volume']+intial_data['overflow_volume'])/cavity_data['max_filling_time'])
    flow_ncavities[1]=piston_flow[1]/((part_data['volume']+intial_data['overflow_volume'])/cavity_data['max_filling_time'])
    flow_ncavities[2]=piston_flow[2]/((part_data['volume']+intial_data['overflow_volume'])/cavity_data['max_filling_time'])
    #maximum number of cavities due to locking force
    force_ncavities=[float(),float(),float()]
    force_ncavities[0]=machine_data['cast_area'][0][1]/(part_data['projection_area']*1.5)
    force_ncavities[1]=machine_data['cast_area'][1][1]/(part_data['projection_area']*1.5)
    force_ncavities[2]=machine_data['cast_area'][2][1]/(part_data['projection_area']*1.5)
    #maximum number of cavities
    cavity_data['max_ncavities'][0]=int(min(volume_ncavities[0],flow_ncavities[0],force_ncavities[0]))
    cavity_data['max_ncavities'][1]=int(min(volume_ncavities[1],flow_ncavities[1],force_ncavities[1]))
    cavity_data['max_ncavities'][2]=int(min(volume_ncavities[2],flow_ncavities[2],force_ncavities[2]))
    return cavity_data
def gate_area(intial_data,part_data,cavity_data,input_data):
    '''
    This function is to calculate the gate area with its dimensions for both cavity inlet and overflow
    '''
    #define intial fields
    gate_data={'gate_area':float(),'gate_height':float(),'gate_width':float(),'overflow_gatearea':float(),'overflow_gatewidth':float(),'overflow_width':float(),'overflow_height':float(),'overflow_length':float()}
    #calculate gate dimensions for AlSi12 (230)
    if input_data['material']=='AlSi12 (230)':
        #calculate gate area
        gate_data['gate_area']=(part_data['volume']+intial_data['overflow_volume'])/((intial_data['gate_velocity']*1000)*cavity_data['max_filling_time'])
        #calculate initial gate height
        gate_data['gate_height']=max(0.8,400/((intial_data['gate_velocity']**1.71)*(intial_data['density']*1000)))
        #calculate initial gate width
        gate_data['gate_width']=gate_data['gate_area']/gate_data['gate_height']
        #adjust gate dimensions
        while gate_data['gate_height']<0.8 or input_data['width']-(gate_data['gate_height']*0.2)<=gate_data['gate_width'] or (intial_data['gate_velocity']**1.71)*gate_data['gate_height']*(intial_data['density']*1000)<400:
            if input_data['width']-(gate_data['gate_height']*0.2)<=gate_data['gate_width']:
                gate_data['gate_height']+=0.1
                gate_data['gate_width']=gate_data['gate_area']/gate_data['gate_height']
            else:
                gate_data['gate_height']-=0.1
                gate_data['gate_width']=gate_data['gate_area']/gate_data['gate_height']
        #calculate overflow dimensions
        gate_data['overflow_gatearea']=(gate_data['gate_area']*intial_data['overflow_volume'])/(part_data['volume']+intial_data['overflow_volume'])
        gate_data['overflow_gatewidth']=min(gate_data['overflow_gatearea']/intial_data['overflow_gateheight'],input_data['width']-4.5)
        intial_data['overflow_gateheight']=gate_data['overflow_gatearea']/gate_data['overflow_gatewidth']
        while input_data['width']<=gate_data['overflow_gatewidth']:
            intial_data['overflow_gateheight']+=0.1
            gate_data['overflow_gatewidth']=gate_data['overflow_gatearea']/intial_data['overflow_gateheight']
        gate_data['overflow_width']=gate_data['overflow_gatewidth']+4.5
        gate_data['overflow_height']=2
        gate_data['overflow_length']=(intial_data['overflow_volume']/(gate_data['overflow_width']*gate_data['overflow_height']))
        i_angle=math.tan(60*math.pi/180)
        while gate_data['overflow_height']/gate_data['overflow_length']<=0.25:
            gate_data['overflow_height']+=0.1
            gate_data['overflow_length']=(intial_data['overflow_volume']/(gate_data['overflow_width']*gate_data['overflow_height']))+0.5*gate_data['overflow_height']*i_angle
    #calculate gate dimensions for ZnAl4 (ZA3)
    elif input_data['material']=='ZnAl4 (ZA3)':
        #calculate gate area
        gate_data['gate_area']=(part_data['volume']+intial_data['overflow_volume'])/((intial_data['gate_velocity']*1000)*cavity_data['max_filling_time'])
        #calculate initial gate height
        gate_data['gate_height']=max(0.2,475/((intial_data['gate_velocity']**1.71)*(intial_data['density']*1000)))
        #calculate initial gate width
        gate_data['gate_width']=gate_data['gate_area']/gate_data['gate_height']
        #adjust gate dimensions
        while gate_data['gate_height']<0.2 or input_data['width']-(gate_data['gate_height']*0.2)<=gate_data['gate_width'] or (intial_data['gate_velocity']**1.71)*gate_data['gate_height']*(intial_data['density']*1000)<475:
            if input_data['width']-(gate_data['gate_height']*0.2)<=gate_data['gate_width']:
                gate_data['gate_height']+=0.1
                gate_data['gate_width']=gate_data['gate_area']/gate_data['gate_height']
            else:
                gate_data['gate_height']-=0.1
                gate_data['gate_width']=gate_data['gate_area']/gate_data['gate_height']
        #calculate overflow dimensions
        gate_data['overflow_gatearea']=(gate_data['gate_area']*intial_data['overflow_volume'])/(part_data['volume']+intial_data['overflow_volume'])
        gate_data['overflow_gatewidth']=min(gate_data['overflow_gatearea']/intial_data['overflow_gateheight'],input_data['width']-4.5)
        intial_data['overflow_gateheight']=gate_data['overflow_gatearea']/gate_data['overflow_gatewidth']
        while input_data['width']<=gate_data['overflow_gatewidth']:
            intial_data['overflow_gateheight']+=0.1
            gate_data['overflow_gatewidth']=gate_data['overflow_gatearea']/intial_data['overflow_gateheight']
        gate_data['overflow_width']=gate_data['overflow_gatewidth']+4.5
        gate_data['overflow_height']=2
        gate_data['overflow_length']=(intial_data['overflow_volume']/(gate_data['overflow_width']*gate_data['overflow_height']))
        i_angle=math.tan(60*math.pi/180)
        while gate_data['overflow_height']/gate_data['overflow_length']<=0.25:
            gate_data['overflow_height']+=0.1
            gate_data['overflow_length']=(intial_data['overflow_volume']/(gate_data['overflow_width']*gate_data['overflow_height']))+0.5*gate_data['overflow_height']*i_angle
    return gate_data
def runner_area(intial_data,gate_data,input_data):
    '''
    This function for calculating runner dimensions
    '''
    #define intial fields
    runner_data={'runner_area':float(),'runner_height':float(),'runner_width':float()}
    #calculate gate dimensions for AlSi12 (230)
    if input_data['material']=='AlSi12 (230)':
        #identify runner area
        if 10<=intial_data['flow_angle'] and intial_data['flow_angle']<=35:
            runner_data['runner_area']=1.3*gate_data['gate_area']
        elif 35<intial_data['flow_angle'] and intial_data['flow_angle']<=45:
            runner_data['runner_area']=1.4*gate_data['gate_area']
        #calculate runner dimensions
        runner_data['runner_height']=gate_data['gate_height']+1
        runner_data['runner_width']=runner_data['runner_area']/runner_data['runner_height']
        while runner_data['runner_height']*3<runner_data['runner_width'] or runner_data['runner_width']<runner_data['runner_height'] or gate_data['gate_width']<runner_data['runner_width']:
            runner_data['runner_height']+=0.1
            runner_data['runner_width']=runner_data['runner_area']/runner_data['runner_height']
    #calculate gate dimensions for ZnAl4 (ZA3)
    elif input_data['material']=='ZnAl4 (ZA3)':
        #identify runner area
        runner_data['runner_area']=1.1*gate_data['gate_area']
        #calculate runner dimensions
        runner_data['runner_height']=gate_data['gate_height']+1
        runner_data['runner_width']=runner_data['runner_area']/runner_data['runner_height']
        while runner_data['runner_height']*3<runner_data['runner_width'] or runner_data['runner_width']<runner_data['runner_height'] or gate_data['gate_width']<runner_data['runner_width']:
            runner_data['runner_height']+=0.1
            runner_data['runner_width']=runner_data['runner_area']/runner_data['runner_height']
    return runner_data
def gate_sections(gate_data,runner_data):
    '''
    This function is to give a detailed dimensions for the gate
    '''
    #define intial feilds
    gate_details={'areas':[float(),float(),float(),float(),float(),float(),float(),float()],'heights':[float(),float(),float(),float(),float(),float(),float(),float()],'widths':[float(),float(),float(),float(),float(),float(),float(),float()],'positions':[float(),float(),float(),float(),float(),float(),float(),float()]}
    #identify areas
    gate_details['areas'][7]=runner_data['runner_area']
    gate_details['areas'][3]=(gate_data['gate_area']+gate_details['areas'][7])/2
    gate_details['areas'][1]=(gate_data['gate_area']+gate_details['areas'][3])/2
    gate_details['areas'][5]=(gate_details['areas'][7]+gate_details['areas'][3])/2
    gate_details['areas'][0]=(gate_data['gate_area']+gate_details['areas'][1])/2
    gate_details['areas'][2]=(gate_details['areas'][1]+gate_details['areas'][3])/2
    gate_details['areas'][4]=(gate_details['areas'][3]+gate_details['areas'][5])/2
    gate_details['areas'][6]=(gate_details['areas'][5]+gate_details['areas'][7])/2
    #identify heights
    gate_details['heights'][7]=runner_data['runner_height']
    gate_details['heights'][3]=(gate_data['gate_height']+gate_details['heights'][7])/2
    gate_details['heights'][1]=(gate_data['gate_height']+gate_details['heights'][3])/2
    gate_details['heights'][5]=(gate_details['heights'][7]+gate_details['heights'][3])/2
    gate_details['heights'][0]=(gate_data['gate_height']+gate_details['heights'][1])/2
    gate_details['heights'][2]=(gate_details['heights'][1]+gate_details['heights'][3])/2
    gate_details['heights'][4]=(gate_details['heights'][3]+gate_details['heights'][5])/2
    gate_details['heights'][6]=(gate_details['heights'][5]+gate_details['heights'][7])/2
    #identify widths
    for i in range(8):
        gate_details['widths'][i]=gate_details['areas'][i]/gate_details['heights'][i]
    #identify positions
    gate_details['positions'][7]=round((runner_data['runner_height']-gate_data['gate_height'])/math.tan(5*(math.pi/180)),2)
    for i in range(7):
        if i==0:
            gate_details['positions'][i]=round(gate_details['positions'][7]/9,2)
        else:
            gate_details['positions'][i]=round(gate_details['positions'][i-1]+gate_details['positions'][7]/9,2)
    return gate_details
def gates_pos(input_data):
    '''
    This function is to locate the optimum location for gate and overflow
    By calculate the optimum GSS and OSS
    '''
    #define intial feilds
    gates_positions={'gss':float(),'oss':float(),'porosity':float()}
    #help array
    pos_array=[[float(),float(),float()],[float(),float(),float()]]
    #calculate gate dimensions for AlSi12 (230)
    if input_data['material']=='AlSi12 (230)':
        gates_positions['gss']=-1
        gates_positions['gss']=-1
        gates_positions['porosity']=5.75-0.00009*input_data['width']-0.00953*input_data['length']-0.0195*input_data['height']+0.208*input_data['thickness']-0.1313*input_data['angle']-0.327*gates_positions['gss']-0.456*gates_positions['oss']-0.000012*(input_data['width']**2)+0.000017*(input_data['length']**2)+0.000106*(input_data['height']**2)+0.2283*(input_data['thickness']**2)+0.000946*(input_data['angle']**2)-0.0934*(gates_positions['gss']**2)+0.1598*(gates_positions['oss']**2)+0.000028*input_data['width']*input_data['length']-0.000068*input_data['width']*input_data['height']+0.00177*input_data['width']*input_data['thickness']+0.000031*input_data['width']*input_data['angle']-0.00003*input_data['width']*gates_positions['gss']+0.00008*input_data['width']*gates_positions['oss']+0.000058*input_data['length']*input_data['height']-0.002092*input_data['length']*input_data['thickness']-0.000031*input_data['length']*input_data['angle']+0.00077*input_data['length']*gates_positions['gss']+0.00072*input_data['length']*gates_positions['oss']-0.00148*input_data['height']*input_data['thickness']+0.000064*input_data['height']*input_data['angle']+0.00179*input_data['height']*gates_positions['gss']+0.00015*input_data['height']*gates_positions['oss']+0.00053*input_data['thickness']*input_data['angle']+0.002*input_data['thickness']*gates_positions['gss']+0.0191*input_data['thickness']*gates_positions['oss']+0.00136*input_data['angle']*gates_positions['gss']+0.00419*input_data['angle']*gates_positions['oss']+0.012*gates_positions['gss']*gates_positions['oss']
        pos_array[0][0]=gates_positions['gss']
        pos_array[0][1]=gates_positions['oss']
        pos_array[0][2]=gates_positions['porosity']
        for gates_positions['gss'] in range(-99,101):
            gates_positions['gss']=gates_positions['gss']/100
            for gates_positions['oss'] in range(-99,101):
                gates_positions['oss']=gates_positions['oss']/100
                gates_positions['porosity']=5.75-0.00009*input_data['width']-0.00953*input_data['length']-0.0195*input_data['height']+0.208*input_data['thickness']-0.1313*input_data['angle']-0.327*gates_positions['gss']-0.456*gates_positions['oss']-0.000012*(input_data['width']**2)+0.000017*(input_data['length']**2)+0.000106*(input_data['height']**2)+0.2283*(input_data['thickness']**2)+0.000946*(input_data['angle']**2)-0.0934*(gates_positions['gss']**2)+0.1598*(gates_positions['oss']**2)+0.000028*input_data['width']*input_data['length']-0.000068*input_data['width']*input_data['height']+0.00177*input_data['width']*input_data['thickness']+0.000031*input_data['width']*input_data['angle']-0.00003*input_data['width']*gates_positions['gss']+0.00008*input_data['width']*gates_positions['oss']+0.000058*input_data['length']*input_data['height']-0.002092*input_data['length']*input_data['thickness']-0.000031*input_data['length']*input_data['angle']+0.00077*input_data['length']*gates_positions['gss']+0.00072*input_data['length']*gates_positions['oss']-0.00148*input_data['height']*input_data['thickness']+0.000064*input_data['height']*input_data['angle']+0.00179*input_data['height']*gates_positions['gss']+0.00015*input_data['height']*gates_positions['oss']+0.00053*input_data['thickness']*input_data['angle']+0.002*input_data['thickness']*gates_positions['gss']+0.0191*input_data['thickness']*gates_positions['oss']+0.00136*input_data['angle']*gates_positions['gss']+0.00419*input_data['angle']*gates_positions['oss']+0.012*gates_positions['gss']*gates_positions['oss']
                pos_array[1][0]=gates_positions['gss']
                pos_array[1][1]=gates_positions['oss']
                pos_array[1][2]=gates_positions['porosity']
                if pos_array[1][2]<=pos_array[0][2]:
                    pos_array[0][0]=pos_array[1][0]
                    pos_array[0][1]=pos_array[1][1]
                    pos_array[0][2]=pos_array[1][2]
        gates_positions['gss']=pos_array[0][0]
        gates_positions['oss']=pos_array[0][1]
        gates_positions['porosity']=pos_array[0][2]
    #calculate gate dimensions for ZnAl4 (ZA3)
    elif input_data['material']=='ZnAl4 (ZA3)':
        gates_positions['gss']=-1
        gates_positions['gss']=-1
        gates_positions['porosity']=-0.061-0.00028*input_data['width']-0.00306*input_data['length']-0.0012*input_data['height']+0.204*input_data['thickness']+0.009*input_data['angle']-0.108*gates_positions['gss']-0.079*gates_positions['oss']+0.000001*(input_data['width']**2)+0.000012*(input_data['length']**2)+0.000015*(input_data['height']**2)+0.1796*(input_data['thickness']**2)-0.000073*(input_data['angle']**2)+0.0049*(gates_positions['gss']**2)-0.0178*(gates_positions['oss']**2)-0.000002*input_data['width']*input_data['length']-0.000005*input_data['width']*input_data['height']+0.000665*input_data['width']*input_data['thickness']-0.000001*input_data['width']*input_data['angle']+0.000106*input_data['width']*gates_positions['gss']+0.000053*input_data['width']*gates_positions['oss']+0.000034*input_data['length']*input_data['height']-0.00252*input_data['length']*input_data['thickness']+0.000002*input_data['length']*input_data['angle']+0.000059*input_data['length']*gates_positions['gss']+0.00007*input_data['length']*gates_positions['oss']-0.00536*input_data['height']*input_data['thickness']+0.000005*input_data['height']*input_data['angle']+0.00026*input_data['height']*gates_positions['gss']+0.00057*input_data['height']*gates_positions['oss']+0.00024*input_data['thickness']*input_data['angle']+0.0111*input_data['thickness']*gates_positions['gss']-0.0032*input_data['thickness']*gates_positions['oss']+0.00071*input_data['angle']*gates_positions['gss']+0.00049*input_data['angle']*gates_positions['oss']+0.005*gates_positions['gss']*gates_positions['oss']
        pos_array[0][0]=gates_positions['gss']
        pos_array[0][1]=gates_positions['oss']
        pos_array[0][2]=gates_positions['porosity']
        for gates_positions['gss'] in range(-99,101):
            gates_positions['gss']=gates_positions['gss']/100
            for gates_positions['oss'] in range(-99,101):
                gates_positions['oss']=gates_positions['oss']/100
                gates_positions['porosity']=-0.061-0.00028*input_data['width']-0.00306*input_data['length']-0.0012*input_data['height']+0.204*input_data['thickness']+0.009*input_data['angle']-0.108*gates_positions['gss']-0.079*gates_positions['oss']+0.000001*(input_data['width']**2)+0.000012*(input_data['length']**2)+0.000015*(input_data['height']**2)+0.1796*(input_data['thickness']**2)-0.000073*(input_data['angle']**2)+0.0049*(gates_positions['gss']**2)-0.0178*(gates_positions['oss']**2)-0.000002*input_data['width']*input_data['length']-0.000005*input_data['width']*input_data['height']+0.000665*input_data['width']*input_data['thickness']-0.000001*input_data['width']*input_data['angle']+0.000106*input_data['width']*gates_positions['gss']+0.000053*input_data['width']*gates_positions['oss']+0.000034*input_data['length']*input_data['height']-0.00252*input_data['length']*input_data['thickness']+0.000002*input_data['length']*input_data['angle']+0.000059*input_data['length']*gates_positions['gss']+0.00007*input_data['length']*gates_positions['oss']-0.00536*input_data['height']*input_data['thickness']+0.000005*input_data['height']*input_data['angle']+0.00026*input_data['height']*gates_positions['gss']+0.00057*input_data['height']*gates_positions['oss']+0.00024*input_data['thickness']*input_data['angle']+0.0111*input_data['thickness']*gates_positions['gss']-0.0032*input_data['thickness']*gates_positions['oss']+0.00071*input_data['angle']*gates_positions['gss']+0.00049*input_data['angle']*gates_positions['oss']+0.005*gates_positions['gss']*gates_positions['oss']
                pos_array[1][0]=gates_positions['gss']
                pos_array[1][1]=gates_positions['oss']
                pos_array[1][2]=gates_positions['porosity']
                if pos_array[1][2]<=pos_array[0][2]:
                    pos_array[0][0]=pos_array[1][0]
                    pos_array[0][1]=pos_array[1][1]
                    pos_array[0][2]=pos_array[1][2]
        gates_positions['gss']=pos_array[0][0]
        gates_positions['oss']=pos_array[0][1]
        gates_positions['porosity']=pos_array[0][2]
    return gates_positions
