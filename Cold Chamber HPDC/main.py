from HPDC import *
'''
This software considered as the used interface for HPDC gating system software
'''
#define input feilds
input_data={'shape':str(),'material':str(),'machine_capacity':str(),'width':float(),'length':float(),'height':float(),'angle':float(),'thickness':float(),'diameter':float()}
#set shape options
shape=['Parallelogram','Cylinder','Hexagonal']
#set machine options
machine=['150TON','250TON','420TON','500TON','650TON']
#set materials options
material=['AlSi12 (230)','ZnAl4 (ZA3)']
#set mold temperatures options
mold_temp={'AlSi12 (230)':[260,280,300,320,340],'ZnAl4 (ZA3)':[205,210,215,220,225,230]}
#set metal temperatures options
metal_temp={'AlSi12 (230)':[600,620,650,680],'ZnAl4 (ZA3)':[405,410,415,420]}
#select shape
#i_counter=0
#for sh in shape:
#    print('[{}] {}'.format(i,sh))
#    i_counter+=1
#input_data['shape']=shape[int(input('Select desired shape: '))]
input_data['shape']='Parallelogram'
#select machine
i_counter=0
for mc in machine:
    print('[{}] {}'.format(i_counter,mc))
    i_counter+=1
input_data['machine_capacity']=machine[int(input('Select desired machine: '))]
#input Parallelogram data
if input_data['shape']=='Parallelogram':
    print('input Parallelogram data')
    input_data['width']=float(input('Specify Parallelogram width= '))
    input_data['length']=float(input('Specify Parallelogram length= '))
    input_data['height']=float(input('Specify Parallelogram height= '))
    input_data['angle']=float(input('Specify Parallelogram angle= '))
#input Cylinder data
elif input_data['shape']=='Cylinder':
    print('input Cylinder data')
    input_data['diameter']=float(input('Specify Cylinder diameter= '))
    input_data['height']=float(input('Specify Cylinder height= '))
#input Hexagonal data
elif input_data['shape']=='Hexagonal':
    print('input Hexagonal data')
    input_data['width']=float(input('Specify Hexagonal width= '))
    input_data['height']=float(input('Specify Hexagonal height= '))
#in case no shape defined
else:
    print("Shape couldn't be found!")
    quit()
#input shape thickness
input_data['thickness']=float(input('Specify shape thickness= '))
#select macterial
i_counter=0
for mat in material:
    print('[{}] {}'.format(i_counter,mat))
    i_counter+=1
input_data['material']=material[int(input('Select desired material: '))]
#get machine data
machine_data=machine_parameters(input_data)
#get part data
part_data=part_paramters(input_data)
#get intial values
intial_data=intial_parameters(input_data,part_data)
#select material tamperature
i_counter=0
for tm in metal_temp[input_data['material']]:
    print('[{}] {} degree'.format(i_counter,tm))
    i_counter+=1
intial_data['metal_temp_gate']=metal_temp[input_data['material']][int(input('Select metal temperature at ingate: '))]
#select mold temperature
i_counter=0
for td in mold_temp[input_data['material']]:
    print('[{}] {} degree'.format(i_counter,td))
    i_counter+=1
intial_data['mold_temp']=mold_temp[input_data['material']][int(input('Select mold temperature: '))]
#get allowed number of cavities
cavity_data=cavities_numbers(intial_data,part_data,machine_data)
#get gate parameters
gate_data=gate_area(intial_data,part_data,cavity_data,input_data)
#get runner parameters
runner_data=runner_area(intial_data,gate_data,input_data)
#get gate sections details
gate_details=gate_sections(gate_data,runner_data)
#get optimum gate and overflow positions
gates_positions=gates_pos(input_data)
#just testing
print(machine_data)
print(part_data)
print(intial_data)
print(cavity_data)
print(gate_data)
print(runner_data)
print(gate_details)
print(gates_positions)
